using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTracker.Controls
{
	public partial class TaskList : UserControl
	{
		private string TodoListPath { get { return Path.Combine( Application.UserAppDataPath, Filename ); } }

		private List<TodoTask> TodoTasks = new List<TodoTask>();

		[ Category( "Behavior" ) ]
		[ Description( "Specifies the filename for backing storage." ) ]
		[ DefaultValue( "tasks.txt" ) ]
		public string Filename { get; set; } = "tasks.txt";

		private TaskList _PromoteTarget = null;

		[Category( "Behavior" )]
		[Description( "Specifies the target task list to promote to." )]
		[DefaultValue( null )]
		public TaskList PromoteTarget
		{
			get { return _PromoteTarget; }
			set
			{
				if( value != _PromoteTarget )
				{
					_PromoteTarget = value;
					buttonPromote.Visible = PromoteTarget != null;
				}
			}
		}

		private TaskList _DemoteTarget = null;

		[Category( "Behavior" )]
		[Description( "Specifies the target task list to demote to." )]
		[DefaultValue( null )]
		public TaskList DemoteTarget
		{
			get { return _DemoteTarget; }
			set
			{
				if( value != _DemoteTarget )
				{
					_DemoteTarget = value;
					buttonDemote.Visible = DemoteTarget != null;
				}
			}
		}

		public TaskList()
		{
			InitializeComponent();
			UpdateColumnWidth();
		}

		private void TaskList_Load( object sender, EventArgs e )
		{
			LoadTasks();

			RefreshTaskListControls();
			UpdateColumnWidth();
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

		private void RefreshTaskListControls()
		{
			var ItemSelected      = listTasks.SelectedItems.Count != 0;
			var FirstItemSelected = ItemSelected && listTasks.SelectedIndices[ 0 ] == 0;
			var LastItemSelected  = ItemSelected && listTasks.SelectedIndices[ 0 ] == listTasks.Items.Count - 1;

			buttonRemove.Enabled = ItemSelected;
			buttonMoveUp.Enabled = !FirstItemSelected;
			buttonMoveDown.Enabled = !LastItemSelected;
		}

		private void UpdateColumnWidth()
		{
			listTasks.Columns[ 0 ].Width = -2;
			listTasks.Columns[ 0 ].Width -= 10;
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
		private TodoTask RemoveTask()
		{
			var listItem = listTasks.SelectedItems[ 0 ];
			listTasks.Items.Remove( listItem );
			listTasks.SelectedItems.Clear();

			var TodoTask = listItem.Tag as TodoTask;
			if( TodoTask != null )
			{
				TodoTasks.Remove( TodoTask );
			}

			return TodoTask;
		}

		internal void AddTask( TodoTask NewTask )
		{
			TodoTasks.Add( NewTask );
			AddTaskToUI( NewTask );
			SaveTasks();
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

		private void TaskList_Resize( object sender, EventArgs e )
		{
			UpdateColumnWidth();
		}

		private void buttonPromote_Click( object sender, EventArgs e )
		{
			if( PromoteTarget == null ) return;

			if( listTasks.SelectedIndices.Count <= 0 ) return;

			var TodoTask = RemoveTask();
			PromoteTarget.AddTask( TodoTask );

			SaveTasks();
		}

		private void buttonDemote_Click( object sender, EventArgs e )
		{
			if( DemoteTarget == null ) return;

			if( listTasks.SelectedIndices.Count <= 0 ) return;

			var TodoTask = RemoveTask();
			DemoteTarget.AddTask( TodoTask );

			SaveTasks();
		}
	}
}
