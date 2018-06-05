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
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load( object sender, EventArgs e )
		{
			RestoreSavedWindowState();
		}

		private void FormMain_FormClosed( object sender, FormClosedEventArgs e )
		{
			SaveWindowState();
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
	}
}
