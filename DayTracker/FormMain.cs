using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTracker
{
	public partial class FormMain : Form
	{
		private const string TimeFormat = "hh:mm tt";

		private string TodoListPath { get { return Path.Combine( Application.UserAppDataPath, "tasks.txt" ); } }

		private string TimePunchListPath { get { return Path.Combine( Application.UserAppDataPath, "clock.txt" ); } }

		private List<TodoTask> TodoTasks = new List<TodoTask>();

		private List<DateTime> TimePunches = new List<DateTime>();

		private enum TimePunchType
		{
			In,
			Out
		}

		public FormMain()
		{
			InitializeComponent();
			UpdateColumnWidth();
		}

		private void FormMain_Load( object sender, EventArgs e )
		{
			LoadTasks();
			LoadTimes();
			textHours.Text = Properties.Settings.Default.ExpectedHours;

			RefreshTaskListControls();
			RefreshTimeListControls();
			RefreshEndTimeText();
			UpdateColumnWidth();

			RestoreSavedWindowState();
		}

		private void LoadTasks()
		{
			if( File.Exists( TodoListPath ) )
			{
				using( var Reader = new StreamReader( TodoListPath ) )
				{
					while( !Reader.EndOfStream )
					{
						TodoTasks.Add( TodoTask.Deserialize( Reader.ReadLine() ) );
					}
				}

				RefreshTaskListView();
			}
		}

		private void SaveTasks()
		{
			using( var Writer = new StreamWriter( TodoListPath ) )
			{
				foreach( var Task in TodoTasks )
				{
					Writer.WriteLine( TodoTask.Serialize( Task ) );
				}
			}
		}

		private void LoadTimes()
		{
			if( File.Exists( TimePunchListPath ) )
			{
				using( var Reader = new StreamReader( TimePunchListPath ) )
				{
					while( !Reader.EndOfStream )
					{
						TimePunches.Add( DateTime.Parse( Reader.ReadLine() ) );
					}
				}

				RefreshTimeListView();
			}
		}

		private void SaveTimes()
		{
			using( var Writer = new StreamWriter( TimePunchListPath ) )
			{
				foreach( var Time in TimePunches )
				{
					Writer.WriteLine( Time.ToString() );
				}
			}
		}

		private void RefreshTaskListView()
		{
			listTasks.BeginUpdate();

			listTasks.Items.Clear();
			foreach( var Task in TodoTasks )
			{
				AddTaskToUI( Task );
			}

			listTasks.EndUpdate();
		}

		private void RefreshTimeListView()
		{
			listTimes.BeginUpdate();

			listTimes.Items.Clear();

			bool IsPunchIn = true;
			foreach( var Time in TimePunches )
			{
				AddTimePunchToUI( IsPunchIn ? TimePunchType.In : TimePunchType.Out, Time );
				IsPunchIn = !IsPunchIn;
			}

			listTimes.EndUpdate();
		}

		private void AddTimePunchToUI( TimePunchType PunchType, DateTime Time )
		{
			var PunchTypeString = ( PunchType == TimePunchType.In ? "In" : "Out" );
			var ListItem = new ListViewItem( new string[] { PunchTypeString, Time.ToString( TimeFormat ) } );
			listTimes.Items.Add( ListItem );
		}

		private TimePunchType GetNextPunchType()
		{
			return TimePunches.Count % 2 == 0 ? TimePunchType.In : TimePunchType.Out;
		}

		private static IEnumerable<TOut> AggregatePairs<TIn, TOut>( IEnumerable<TIn> Values, Func<TIn, TIn, TOut> Aggregator )
		{
			var Enumerator = Values.GetEnumerator();

			while( Enumerator.MoveNext() )
			{
				var Value1 = Enumerator.Current;

				if( Enumerator.MoveNext() )
				{
					var Value2 = Enumerator.Current;
					yield return Aggregator( Value1, Value2 );
				}
			}
			
			yield break;
		}

		private double GetTotalLoggedHours()
		{
			if( TimePunches.Count > 1 )
			{
				return AggregatePairs( TimePunches, ( t1, t2 ) => t2 - t1 ).Aggregate( ( s1, s2 ) => s1 + s2 ).TotalHours;
			}

			return 0;
		}

		private void RefreshTaskListControls()
		{
			var ItemSelected      = listTasks.SelectedItems.Count != 0;
			var FirstItemSelected = ItemSelected && listTasks.SelectedIndices[ 0 ] == 0;
			var LastItemSelected  = ItemSelected && listTasks.SelectedIndices[ 0 ] == listTasks.Items.Count - 1;

			buttonRemove.Enabled   = ItemSelected;
			buttonMoveUp.Enabled   = !FirstItemSelected;
			buttonMoveDown.Enabled = !LastItemSelected;
		}

		private void RefreshTimeListControls()
		{
			buttonTimeStart.Enabled = GetNextPunchType() == TimePunchType.In;
			buttonTimeEnd.Enabled   = GetNextPunchType() == TimePunchType.Out;
		}

		private void UpdateColumnWidth()
		{
			listTasks.Columns[ 0 ].Width = -2;
			listTasks.Columns[ 0 ].Width -= 10;

			//listTimes.Columns[ 1 ].Width = -2;
			//listTimes.Columns[ 1 ].Width -= 10;
		}

		private ListViewItem AddTaskToUI( TodoTask Task )
		{
			var ListItem = new ListViewItem( Task.Description );
			ListItem.Checked = Task.Completed;
			ListItem.Tag = Task;
			listTasks.Items.Add( ListItem );

			return ListItem;
		}

		private void MoveTask( int OldIndex, int NewIndex )
		{
			var ListItem = listTasks.Items[ OldIndex ];
			listTasks.Items.RemoveAt( OldIndex );
			listTasks.Items.Insert( NewIndex, ListItem );

			var TodoTask = TodoTasks[ OldIndex ];
			TodoTasks.RemoveAt( OldIndex );
			TodoTasks.Insert( NewIndex, TodoTask );
		}
		private void RemoveTask()
		{
			var listItem = listTasks.SelectedItems[ 0 ];
			listTasks.Items.Remove( listItem );
			listTasks.SelectedItems.Clear();

			var TodoTask = listItem.Tag as TodoTask;
			if( TodoTask != null )
			{
				TodoTasks.Remove( TodoTask );
			}
		}

		private void RestoreSavedWindowState()
		{
			var SavedLocation = Properties.Settings.Default.WindowPosition;
			if( SavedLocation != Point.Empty ) Location = SavedLocation;

			var SavedSize = Properties.Settings.Default.WindowSize;
			if( SavedSize != Size.Empty ) Size = SavedSize;

			WindowState = Properties.Settings.Default.WindowState;
		}

		private void SaveWindowState()
		{
			if( WindowState == FormWindowState.Normal )
			{
				Properties.Settings.Default.WindowPosition = Location;
				Properties.Settings.Default.WindowSize = Size;
			}
			else
			{
				Properties.Settings.Default.WindowPosition = RestoreBounds.Location;
				Properties.Settings.Default.WindowSize = RestoreBounds.Size;
			}

			if( WindowState != FormWindowState.Minimized )
			{
				Properties.Settings.Default.WindowState = WindowState;
			}
			else
			{
				Properties.Settings.Default.WindowState = FormWindowState.Normal;
			}

			Properties.Settings.Default.Save();
		}

		private void buttonAdd_Click( object sender, EventArgs e )
		{
			var NewTask = new TodoTask( "" );
			TodoTasks.Add( NewTask );

			var ListItem = AddTaskToUI( NewTask );
			ListItem.BeginEdit();
		}

		private void buttonRemove_Click( object sender, EventArgs e )
		{
			if( listTasks.SelectedItems.Count <= 0 ) return;

			var SelectedIndex = listTasks.SelectedIndices[ 0 ];
			RemoveTask();

			if( listTasks.Items.Count > 0 )
			{
				listTasks.SelectedIndices.Add( Math.Max( 0, SelectedIndex - 1 ) );
			}
			listTasks.Focus();

			SaveTasks();
		}


		private void listTasks_SelectedIndexChanged( object sender, EventArgs e )
		{
			RefreshTaskListControls();
		}

		private void listTasks_ItemChecked( object sender, ItemCheckedEventArgs e )
		{
			var TodoTask = e.Item.Tag as TodoTask;
			if( TodoTask != null )
			{
				TodoTask.Completed = e.Item.Checked;
			}

			SaveTasks();
		}

		private void listTasks_AfterLabelEdit( object sender, LabelEditEventArgs e )
		{
			var TodoTask = listTasks.Items[ e.Item ].Tag as TodoTask;
			if( TodoTask != null )
			{
				if( string.IsNullOrEmpty( e.Label ) && !string.IsNullOrEmpty( TodoTask.Description ) )
				{
					e.CancelEdit = true;
				}
				else
				{
					TodoTask.Description = e.Label;
					SaveTasks();
				}
			}
		}

		private void buttonMoveUp_Click( object sender, EventArgs e )
		{
			if( listTasks.SelectedIndices.Count <= 0 ) return;

			if( listTasks.SelectedIndices[ 0 ] <= 0 ) return;

			var OldIndex = listTasks.SelectedIndices[ 0 ];
			var NewIndex = OldIndex - 1;

			MoveTask( OldIndex, NewIndex );
			listTasks.Focus();

			SaveTasks();
		}

		private void buttonMoveDown_Click( object sender, EventArgs e )
		{
			if( listTasks.SelectedIndices.Count <= 0 ) return;

			if( listTasks.SelectedIndices[ 0 ] >= listTasks.Items.Count ) return;

			var OldIndex = listTasks.SelectedIndices[ 0 ];
			var NewIndex = OldIndex + 1;

			MoveTask( OldIndex, NewIndex );
			listTasks.Focus();

			SaveTasks();
		}

		private void FormMain_ResizeEnd( object sender, EventArgs e )
		{
			UpdateColumnWidth();
		}

		private void FormMain_FormClosed( object sender, FormClosedEventArgs e )
		{
			SaveWindowState();
		}

		private void buttonTimeStart_Click( object sender, EventArgs e )
		{
			ShowTimePunchDialog( "Enter Clock In Time..." );
		}

		private void buttonTimeEnd_Click( object sender, EventArgs e )
		{
			ShowTimePunchDialog( "Enter Clock Out Time..." );
		}

		private void ShowTimePunchDialog( string DialogTitle )
		{
			var TimeDialog = new FormTimePunch();
			TimeDialog.Text = DialogTitle;
			TimeDialog.Time = FormTimePunch.GetApproximateTime( DateTime.Now );

			var Result = TimeDialog.ShowDialog( this );
			if( Result == DialogResult.OK )
			{
				AddTimePunchToUI( GetNextPunchType(), TimeDialog.Time );
				TimePunches.Add( TimeDialog.Time );

				RefreshTimeListControls();
				RefreshEndTimeText();
			}

			SaveTimes();
		}

		private void buttonTimeClear_Click( object sender, EventArgs e )
		{
			var Result = MessageBox.Show( this, "Are you sure you want to clear all time punches?", "Confirm Clear", MessageBoxButtons.YesNo );
			if( Result == DialogResult.Yes )
			{
				listTimes.Items.Clear();
				TimePunches.Clear();
				SaveTimes();

				RefreshTimeListControls();
			}
		}

		private void textHours_TextChanged( object sender, EventArgs e )
		{
			RefreshEndTimeText();
			Properties.Settings.Default.ExpectedHours = textHours.Text;
		}

		private void RefreshEndTimeText()
		{
			var NewEndTimeText = "---";

			int Hours;
			if( int.TryParse( textHours.Text, out Hours ) )
			{
				var RemainingHours = Hours - GetTotalLoggedHours();

				if( GetNextPunchType() == TimePunchType.Out )
				{
					var LastStartTime = TimePunches.Last();
					var SuggestedEndTime = LastStartTime.AddHours( RemainingHours );
					NewEndTimeText = FormTimePunch.GetApproximateTime( SuggestedEndTime ).ToString( TimeFormat );
				}
			}

			textEndTime.Text = NewEndTimeText;
		}
	}
}
