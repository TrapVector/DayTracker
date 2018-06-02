using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayTracker
{
	public partial class FormTimePunch : Form
	{
		private DateTime _Time;
		public DateTime Time
		{
			get { return _Time; }
			set
			{
				if( _Time != value )
				{
					_Time = value;
					timePicker.Value = Time;
				}
			}
		}

		public FormTimePunch()
		{
			InitializeComponent();
		}

		private void timePicker_ValueChanged( object sender, EventArgs e )
		{
			_Time = timePicker.Value;
		}

		private void buttonOk_Click( object sender, EventArgs e )
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void buttonCancel_Click( object sender, EventArgs e )
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		public static DateTime GetApproximateTime( DateTime ActualTime )
		{
			var HourIncrement = 0;
			var ApproximateMinute = (int)( Math.Round( ActualTime.Minute / 15.0 ) ) * 15;
			if( ApproximateMinute == 60 )
			{
				HourIncrement     = 1;
				ApproximateMinute = 0;
			}

			var ApproximateTime = new DateTime(
				ActualTime.Year, ActualTime.Month, ActualTime.Day,
				ActualTime.Hour + HourIncrement, ApproximateMinute, 0 );

			return ApproximateTime;
		}
	}
}
