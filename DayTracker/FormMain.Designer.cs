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
			this.buttonMoveDown = new System.Windows.Forms.Button();
			this.buttonMoveUp = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.listTasks = new System.Windows.Forms.ListView();
			this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonAdd = new System.Windows.Forms.Button();
			this.tabTime = new System.Windows.Forms.TabPage();
			this.buttonTimeClear = new System.Windows.Forms.Button();
			this.labelEndTime = new System.Windows.Forms.Label();
			this.labelHours = new System.Windows.Forms.Label();
			this.buttonTimeEnd = new System.Windows.Forms.Button();
			this.textEndTime = new System.Windows.Forms.TextBox();
			this.textHours = new System.Windows.Forms.TextBox();
			this.buttonTimeStart = new System.Windows.Forms.Button();
			this.listTimes = new System.Windows.Forms.ListView();
			this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
			this.tabPlan.Controls.Add(this.buttonMoveDown);
			this.tabPlan.Controls.Add(this.buttonMoveUp);
			this.tabPlan.Controls.Add(this.buttonRemove);
			this.tabPlan.Controls.Add(this.listTasks);
			this.tabPlan.Controls.Add(this.buttonAdd);
			this.tabPlan.Location = new System.Drawing.Point(4, 22);
			this.tabPlan.Name = "tabPlan";
			this.tabPlan.Padding = new System.Windows.Forms.Padding(3);
			this.tabPlan.Size = new System.Drawing.Size(276, 235);
			this.tabPlan.TabIndex = 0;
			this.tabPlan.Text = "Plan";
			this.tabPlan.UseVisualStyleBackColor = true;
			// 
			// buttonMoveDown
			// 
			this.buttonMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMoveDown.Image = global::DayTracker.Properties.Resources.bullet_arrow_down;
			this.buttonMoveDown.Location = new System.Drawing.Point(246, 93);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(23, 23);
			this.buttonMoveDown.TabIndex = 5;
			this.buttonMoveDown.UseVisualStyleBackColor = true;
			this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
			// 
			// buttonMoveUp
			// 
			this.buttonMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMoveUp.Image = global::DayTracker.Properties.Resources.bullet_arrow_up;
			this.buttonMoveUp.Location = new System.Drawing.Point(246, 64);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(23, 23);
			this.buttonMoveUp.TabIndex = 4;
			this.buttonMoveUp.UseVisualStyleBackColor = true;
			this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
			// 
			// buttonRemove
			// 
			this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRemove.Image = global::DayTracker.Properties.Resources.delete;
			this.buttonRemove.Location = new System.Drawing.Point(246, 35);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(23, 23);
			this.buttonRemove.TabIndex = 3;
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			// 
			// listTasks
			// 
			this.listTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listTasks.CheckBoxes = true;
			this.listTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDescription});
			this.listTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listTasks.HideSelection = false;
			this.listTasks.LabelEdit = true;
			this.listTasks.Location = new System.Drawing.Point(6, 6);
			this.listTasks.MultiSelect = false;
			this.listTasks.Name = "listTasks";
			this.listTasks.Size = new System.Drawing.Size(234, 223);
			this.listTasks.TabIndex = 2;
			this.listTasks.UseCompatibleStateImageBehavior = false;
			this.listTasks.View = System.Windows.Forms.View.Details;
			this.listTasks.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listTasks_AfterLabelEdit);
			this.listTasks.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listTasks_ItemChecked);
			this.listTasks.SelectedIndexChanged += new System.EventHandler(this.listTasks_SelectedIndexChanged);
			// 
			// columnDescription
			// 
			this.columnDescription.Text = "Description";
			this.columnDescription.Width = 25;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdd.Image = global::DayTracker.Properties.Resources.add;
			this.buttonAdd.Location = new System.Drawing.Point(246, 6);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(23, 23);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// tabTime
			// 
			this.tabTime.Controls.Add(this.buttonTimeClear);
			this.tabTime.Controls.Add(this.labelEndTime);
			this.tabTime.Controls.Add(this.labelHours);
			this.tabTime.Controls.Add(this.buttonTimeEnd);
			this.tabTime.Controls.Add(this.textEndTime);
			this.tabTime.Controls.Add(this.textHours);
			this.tabTime.Controls.Add(this.buttonTimeStart);
			this.tabTime.Controls.Add(this.listTimes);
			this.tabTime.Location = new System.Drawing.Point(4, 22);
			this.tabTime.Name = "tabTime";
			this.tabTime.Padding = new System.Windows.Forms.Padding(3);
			this.tabTime.Size = new System.Drawing.Size(276, 235);
			this.tabTime.TabIndex = 1;
			this.tabTime.Text = "Time";
			this.tabTime.UseVisualStyleBackColor = true;
			// 
			// buttonTimeClear
			// 
			this.buttonTimeClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimeClear.Image = global::DayTracker.Properties.Resources.clock_delete;
			this.buttonTimeClear.Location = new System.Drawing.Point(247, 64);
			this.buttonTimeClear.Name = "buttonTimeClear";
			this.buttonTimeClear.Size = new System.Drawing.Size(23, 23);
			this.buttonTimeClear.TabIndex = 7;
			this.buttonTimeClear.UseVisualStyleBackColor = true;
			this.buttonTimeClear.Click += new System.EventHandler(this.buttonTimeClear_Click);
			// 
			// labelEndTime
			// 
			this.labelEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelEndTime.AutoSize = true;
			this.labelEndTime.Location = new System.Drawing.Point(54, 193);
			this.labelEndTime.Name = "labelEndTime";
			this.labelEndTime.Size = new System.Drawing.Size(55, 13);
			this.labelEndTime.TabIndex = 6;
			this.labelEndTime.Text = "Expected:";
			// 
			// labelHours
			// 
			this.labelHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelHours.AutoSize = true;
			this.labelHours.Location = new System.Drawing.Point(3, 193);
			this.labelHours.Name = "labelHours";
			this.labelHours.Size = new System.Drawing.Size(38, 13);
			this.labelHours.TabIndex = 5;
			this.labelHours.Text = "Hours:";
			// 
			// buttonTimeEnd
			// 
			this.buttonTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimeEnd.Image = global::DayTracker.Properties.Resources.clock_stop;
			this.buttonTimeEnd.Location = new System.Drawing.Point(247, 35);
			this.buttonTimeEnd.Name = "buttonTimeEnd";
			this.buttonTimeEnd.Size = new System.Drawing.Size(23, 23);
			this.buttonTimeEnd.TabIndex = 4;
			this.buttonTimeEnd.UseVisualStyleBackColor = true;
			this.buttonTimeEnd.Click += new System.EventHandler(this.buttonTimeEnd_Click);
			// 
			// textEndTime
			// 
			this.textEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEndTime.Location = new System.Drawing.Point(57, 209);
			this.textEndTime.Name = "textEndTime";
			this.textEndTime.ReadOnly = true;
			this.textEndTime.Size = new System.Drawing.Size(184, 20);
			this.textEndTime.TabIndex = 3;
			// 
			// textHours
			// 
			this.textHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textHours.Location = new System.Drawing.Point(6, 209);
			this.textHours.Name = "textHours";
			this.textHours.Size = new System.Drawing.Size(45, 20);
			this.textHours.TabIndex = 2;
			this.textHours.TextChanged += new System.EventHandler(this.textHours_TextChanged);
			// 
			// buttonTimeStart
			// 
			this.buttonTimeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimeStart.Image = global::DayTracker.Properties.Resources.clock_play;
			this.buttonTimeStart.Location = new System.Drawing.Point(247, 6);
			this.buttonTimeStart.Name = "buttonTimeStart";
			this.buttonTimeStart.Size = new System.Drawing.Size(23, 23);
			this.buttonTimeStart.TabIndex = 1;
			this.buttonTimeStart.UseVisualStyleBackColor = true;
			this.buttonTimeStart.Click += new System.EventHandler(this.buttonTimeStart_Click);
			// 
			// listTimes
			// 
			this.listTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnType,
            this.columnTime});
			this.listTimes.FullRowSelect = true;
			this.listTimes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listTimes.Location = new System.Drawing.Point(6, 6);
			this.listTimes.MultiSelect = false;
			this.listTimes.Name = "listTimes";
			this.listTimes.Size = new System.Drawing.Size(235, 184);
			this.listTimes.TabIndex = 0;
			this.listTimes.UseCompatibleStateImageBehavior = false;
			this.listTimes.View = System.Windows.Forms.View.Details;
			// 
			// columnTime
			// 
			this.columnTime.Text = "Time";
			// 
			// columnType
			// 
			this.columnType.Text = "Type";
			this.columnType.Width = 45;
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
			this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
			this.tabsMain.ResumeLayout(false);
			this.tabPlan.ResumeLayout(false);
			this.tabTime.ResumeLayout(false);
			this.tabTime.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabsMain;
		private System.Windows.Forms.TabPage tabPlan;
		private System.Windows.Forms.TabPage tabTime;
		private System.Windows.Forms.ListView listTasks;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonMoveDown;
		private System.Windows.Forms.Button buttonMoveUp;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.ColumnHeader columnDescription;
		private System.Windows.Forms.Label labelEndTime;
		private System.Windows.Forms.Label labelHours;
		private System.Windows.Forms.Button buttonTimeEnd;
		private System.Windows.Forms.TextBox textEndTime;
		private System.Windows.Forms.TextBox textHours;
		private System.Windows.Forms.Button buttonTimeStart;
		private System.Windows.Forms.ListView listTimes;
		private System.Windows.Forms.Button buttonTimeClear;
		private System.Windows.Forms.ColumnHeader columnTime;
		private System.Windows.Forms.ColumnHeader columnType;
	}
}

