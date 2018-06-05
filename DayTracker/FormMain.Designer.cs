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
			this.tabPlan = new System.Windows.Forms.TabPage();
			this.taskList1 = new DayTracker.Controls.TaskList();
			this.tabTime = new System.Windows.Forms.TabPage();
			this.timePunchList1 = new DayTracker.Controls.TimePunchList();
			this.tabsMain.SuspendLayout();
			this.tabPlan.SuspendLayout();
			this.tabTime.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabsMain
			// 
			this.tabsMain.Controls.Add(this.tabPlan);
			this.tabsMain.Controls.Add(this.tabTime);
			this.tabsMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabsMain.Location = new System.Drawing.Point(0, 0);
			this.tabsMain.Name = "tabsMain";
			this.tabsMain.SelectedIndex = 0;
			this.tabsMain.Size = new System.Drawing.Size(284, 261);
			this.tabsMain.TabIndex = 0;
			// 
			// tabPlan
			// 
			this.tabPlan.Controls.Add(this.taskList1);
			this.tabPlan.Location = new System.Drawing.Point(4, 22);
			this.tabPlan.Name = "tabPlan";
			this.tabPlan.Padding = new System.Windows.Forms.Padding(3);
			this.tabPlan.Size = new System.Drawing.Size(276, 235);
			this.tabPlan.TabIndex = 0;
			this.tabPlan.Text = "Plan";
			this.tabPlan.UseVisualStyleBackColor = true;
			// 
			// taskList1
			// 
			this.taskList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.taskList1.Location = new System.Drawing.Point(3, 3);
			this.taskList1.Name = "taskList1";
			this.taskList1.Size = new System.Drawing.Size(270, 229);
			this.taskList1.TabIndex = 0;
			// 
			// tabTime
			// 
			this.tabTime.Controls.Add(this.timePunchList1);
			this.tabTime.Location = new System.Drawing.Point(4, 22);
			this.tabTime.Name = "tabTime";
			this.tabTime.Padding = new System.Windows.Forms.Padding(3);
			this.tabTime.Size = new System.Drawing.Size(276, 235);
			this.tabTime.TabIndex = 1;
			this.tabTime.Text = "Time";
			this.tabTime.UseVisualStyleBackColor = true;
			// 
			// timePunchList1
			// 
			this.timePunchList1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.timePunchList1.Location = new System.Drawing.Point(3, 3);
			this.timePunchList1.Name = "timePunchList1";
			this.timePunchList1.Size = new System.Drawing.Size(270, 229);
			this.timePunchList1.TabIndex = 0;
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
			this.Text = "Today";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.tabsMain.ResumeLayout(false);
			this.tabPlan.ResumeLayout(false);
			this.tabTime.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabsMain;
		private System.Windows.Forms.TabPage tabPlan;
		private System.Windows.Forms.TabPage tabTime;
		private Controls.TaskList taskList1;
		private Controls.TimePunchList timePunchList1;
	}
}

