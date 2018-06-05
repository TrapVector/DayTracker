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
	public partial class TimePunchList : UserControl
	{
		private const string TimeFormat = "hh:mm tt";

		private string TimePunchListPath { get { return Path.Combine( Application.UserAppDataPath, "clock.txt" ); } }

		private List<DateTime> TimePunches = new List<DateTime>();

		private enum TimePunchType
		{
			In,
			Out
		}

		public TimePunchList()
		{
			InitializeComponent();
		}

		private void TimePunchList_Load( object sender, EventArgs e )
		{
			LoadTimes();
			textHours.Text = Properties.Settings.Default.ExpectedHours;

			RefreshTimeListControls();
			RefreshEndTimeText();
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

		private void RefreshTimeListControls()
		{
			buttonTimeStart.Enabled = GetNextPunchType() == TimePunchType.In;
			buttonTimeEnd.Enabled = GetNextPunchType() == TimePunchType.Out;
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
