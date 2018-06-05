namespace DayTracker
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.tabsMain = new System.Windows.Forms.TabControl();
			this.tabToday = new System.Windows.Forms.TabPage();
			this.taskListToday = new DayTracker.Controls.TaskList();
			this.taskListBacklog = new DayTracker.Controls.TaskList();
			this.tabBacklog = new System.Windows.Forms.TabPage();
			this.tabTime = new System.Windows.Forms.TabPage();
			this.timePunchList = new DayTracker.Controls.TimePunchList();
			this.tabsMain.SuspendLayout();
			this.tabToday.SuspendLayout();
			this.tabBacklog.SuspendLayout();
			this.tabTime.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabsMain
			// 
			this.tabsMain.Controls.Add(this.tabToday);
			this.tabsMain.Controls.Add(this.tabBacklog);
			this.tabsMain.Controls.Add(this.tabTime);
			this.tabsMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabsMain.Location = new System.Drawing.Point(0, 0);
			this.tabsMain.Name = "tabsMain";
			this.tabsMain.SelectedIndex = 0;
			this.tabsMain.Size = new System.Drawing.Size(284, 261);
			this.tabsMain.TabIndex = 0;
			// 
			// tabToday
			// 
			this.tabToday.Controls.Add(this.taskListToday);
			this.tabToday.Location = new System.Drawing.Point(4, 22);
			this.tabToday.Name = "tabToday";
			this.tabToday.Padding = new System.Windows.Forms.Padding(3);
			this.tabToday.Size = new System.Drawing.Size(276, 235);
			this.tabToday.TabIndex = 0;
			this.tabToday.Text = "Today";
			this.tabToday.UseVisualStyleBackColor = true;
			// 
			// taskListToday
			// 
			this.taskListToday.DemoteTarget = this.taskListBacklog;
			this.taskListToday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.taskListToday.Location = new System.Drawing.Point(3, 3);
			this.taskListToday.Name = "taskListToday";
			this.taskListToday.Size = new System.Drawing.Size(270, 229);
			this.taskListToday.TabIndex = 0;
			// 
			// taskListBacklog
			// 
			this.taskListBacklog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.taskListBacklog.Filename = "backlog.txt";
			this.taskListBacklog.Location = new System.Drawing.Point(3, 3);
			this.taskListBacklog.Name = "taskListBacklog";
			this.taskListBacklog.PromoteTarget = this.taskListToday;
			this.taskListBacklog.Size = new System.Drawing.Size(270, 229);
			this.taskListBacklog.TabIndex = 0;
			// 
			// tabBacklog
			// 
			this.tabBacklog.Controls.Add(this.taskListBacklog);
			this.tabBacklog.Location = new System.Drawing.Point(4, 22);
			this.tabBacklog.Name = "tabBacklog";
			this.tabBacklog.Padding = new System.Windows.Forms.Padding(3);
			this.tabBacklog.Size = new System.Drawing.Size(276, 235);
			this.tabBacklog.TabIndex = 2;
			this.tabBacklog.Text = "Backlog";
			this.tabBacklog.UseVisualStyleBackColor = true;
			// 
			// tabTime
			// 
			this.tabTime.Controls.Add(this.timePunchList);
			this.tabTime.Location = new System.Drawing.Point(4, 22);
			this.tabTime.Name = "tabTime";
			this.tabTime.Padding = new System.Windows.Forms.Padding(3);
			this.tabTime.Size = new System.Drawing.Size(276, 235);
			this.tabTime.TabIndex = 1;
			this.tabTime.Text = "Time";
			this.tabTime.UseVisualStyleBackColor = true;
			// 
			// timePunchList
			// 
			this.timePunchList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timePunchList.Location = new System.Drawing.Point(3, 3);
			this.timePunchList.Name = "timePunchList";
			this.timePunchList.Size = new System.Drawing.Size(270, 229);
			this.timePunchList.TabIndex = 0;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.tabsMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.Text = "Day Tracker";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.tabsMain.ResumeLayout(false);
			this.tabToday.ResumeLayout(false);
			this.tabBacklog.ResumeLayout(false);
			this.tabTime.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabsMain;
		private System.Windows.Forms.TabPage tabToday;
		private System.Windows.Forms.TabPage tabTime;
		private Controls.TaskList taskListToday;
		private Controls.TimePunchList timePunchList;
		private System.Windows.Forms.TabPage tabBacklog;
		private Controls.TaskList taskListBacklog;
	}
}

