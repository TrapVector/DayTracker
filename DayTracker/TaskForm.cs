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
	public partial class TaskForm : Form
	{
		private string _Description;

		public string Description
		{
			get { return _Description; }
			set
			{
				if( value != _Description )
				{
					_Description = value;
					textDescription.Text = _Description;
				}
			}
		}

		public TaskForm()
		{
			InitializeComponent();
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

		private void textDescription_TextChanged( object sender, EventArgs e )
		{
			_Description = textDescription.Text;
		}
	}
}
