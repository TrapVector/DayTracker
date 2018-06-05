namespace DayTracker.Controls
{
	partial class TimePunchList
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonTimeClear = new System.Windows.Forms.Button();
			this.labelEndTime = new System.Windows.Forms.Label();
			this.labelHours = new System.Windows.Forms.Label();
			this.buttonTimeEnd = new System.Windows.Forms.Button();
			this.textEndTime = new System.Windows.Forms.TextBox();
			this.textHours = new System.Windows.Forms.TextBox();
			this.buttonTimeStart = new System.Windows.Forms.Button();
			this.listTimes = new System.Windows.Forms.ListView();
			this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// buttonTimeClear
			// 
			this.buttonTimeClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimeClear.Image = global::DayTracker.Properties.Resources.clock_delete;
			this.buttonTimeClear.Location = new System.Drawing.Point(193, 61);
			this.buttonTimeClear.Name = "buttonTimeClear";
			this.buttonTimeClear.Size = new System.Drawing.Size(23, 23);
			this.buttonTimeClear.TabIndex = 15;
			this.buttonTimeClear.UseVisualStyleBackColor = true;
			this.buttonTimeClear.Click += new System.EventHandler(this.buttonTimeClear_Click);
			// 
			// labelEndTime
			// 
			this.labelEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelEndTime.AutoSize = true;
			this.labelEndTime.Location = new System.Drawing.Point(51, 160);
			this.labelEndTime.Name = "labelEndTime";
			this.labelEndTime.Size = new System.Drawing.Size(55, 13);
			this.labelEndTime.TabIndex = 14;
			this.labelEndTime.Text = "Expected:";
			// 
			// labelHours
			// 
			this.labelHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelHours.AutoSize = true;
			this.labelHours.Location = new System.Drawing.Point(0, 160);
			this.labelHours.Name = "labelHours";
			this.labelHours.Size = new System.Drawing.Size(38, 13);
			this.labelHours.TabIndex = 13;
			this.labelHours.Text = "Hours:";
			// 
			// buttonTimeEnd
			// 
			this.buttonTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimeEnd.Image = global::DayTracker.Properties.Resources.clock_stop;
			this.buttonTimeEnd.Location = new System.Drawing.Point(193, 32);
			this.buttonTimeEnd.Name = "buttonTimeEnd";
			this.buttonTimeEnd.Size = new System.Drawing.Size(23, 23);
			this.buttonTimeEnd.TabIndex = 12;
			this.buttonTimeEnd.UseVisualStyleBackColor = true;
			this.buttonTimeEnd.Click += new System.EventHandler(this.buttonTimeEnd_Click);
			// 
			// textEndTime
			// 
			this.textEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEndTime.Location = new System.Drawing.Point(54, 176);
			this.textEndTime.Name = "textEndTime";
			this.textEndTime.ReadOnly = true;
			this.textEndTime.Size = new System.Drawing.Size(133, 20);
			this.textEndTime.TabIndex = 11;
			// 
			// textHours
			// 
			this.textHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textHours.Location = new System.Drawing.Point(3, 176);
			this.textHours.Name = "textHours";
			this.textHours.Size = new System.Drawing.Size(45, 20);
			this.textHours.TabIndex = 10;
			this.textHours.TextChanged += new System.EventHandler(this.textHours_TextChanged);
			// 
			// buttonTimeStart
			// 
			this.buttonTimeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTimeStart.Image = global::DayTracker.Properties.Resources.clock_play;
			this.buttonTimeStart.Location = new System.Drawing.Point(193, 3);
			this.buttonTimeStart.Name = "buttonTimeStart";
			this.buttonTimeStart.Size = new System.Drawing.Size(23, 23);
			this.buttonTimeStart.TabIndex = 9;
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
			this.listTimes.Location = new System.Drawing.Point(3, 3);
			this.listTimes.MultiSelect = false;
			this.listTimes.Name = "listTimes";
			this.listTimes.Size = new System.Drawing.Size(184, 154);
			this.listTimes.TabIndex = 8;
			this.listTimes.UseCompatibleStateImageBehavior = false;
			this.listTimes.View = System.Windows.Forms.View.Details;
			// 
			// columnType
			// 
			this.columnType.Text = "Type";
			this.columnType.Width = 45;
			// 
			// columnTime
			// 
			this.columnTime.Text = "Time";
			// 
			// TimePunchList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonTimeClear);
			this.Controls.Add(this.labelEndTime);
			this.Controls.Add(this.labelHours);
			this.Controls.Add(this.buttonTimeEnd);
			this.Controls.Add(this.textEndTime);
			this.Controls.Add(this.textHours);
			this.Controls.Add(this.buttonTimeStart);
			this.Controls.Add(this.listTimes);
			this.Name = "TimePunchList";
			this.Size = new System.Drawing.Size(219, 199);
			this.Load += new System.EventHandler(this.TimePunchList_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonTimeClear;
		private System.Windows.Forms.Label labelEndTime;
		private System.Windows.Forms.Label labelHours;
		private System.Windows.Forms.Button buttonTimeEnd;
		private System.Windows.Forms.TextBox textEndTime;
		private System.Windows.Forms.TextBox textHours;
		private System.Windows.Forms.Button buttonTimeStart;
		private System.Windows.Forms.ListView listTimes;
		private System.Windows.Forms.ColumnHeader columnType;
		private System.Windows.Forms.ColumnHeader columnTime;
	}
}
