namespace DayTracker.Controls
{
	partial class TaskList
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
			this.listTasks = new System.Windows.Forms.ListView();
			this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonPromote = new System.Windows.Forms.Button();
			this.buttonMoveDown = new System.Windows.Forms.Button();
			this.buttonMoveUp = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDemote = new System.Windows.Forms.Button();
			this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayout.SuspendLayout();
			this.SuspendLayout();
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
			this.listTasks.Location = new System.Drawing.Point(3, 3);
			this.listTasks.MultiSelect = false;
			this.listTasks.Name = "listTasks";
			this.listTasks.Size = new System.Drawing.Size(188, 193);
			this.listTasks.TabIndex = 7;
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
			// buttonPromote
			// 
			this.buttonPromote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPromote.Image = global::DayTracker.Properties.Resources.hourglass_go;
			this.buttonPromote.Location = new System.Drawing.Point(3, 119);
			this.buttonPromote.Name = "buttonPromote";
			this.buttonPromote.Size = new System.Drawing.Size(23, 23);
			this.buttonPromote.TabIndex = 11;
			this.buttonPromote.UseVisualStyleBackColor = true;
			this.buttonPromote.Visible = false;
			this.buttonPromote.Click += new System.EventHandler(this.buttonPromote_Click);
			// 
			// buttonMoveDown
			// 
			this.buttonMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMoveDown.Image = global::DayTracker.Properties.Resources.bullet_arrow_down;
			this.buttonMoveDown.Location = new System.Drawing.Point(3, 90);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(23, 23);
			this.buttonMoveDown.TabIndex = 10;
			this.buttonMoveDown.UseVisualStyleBackColor = true;
			this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
			// 
			// buttonMoveUp
			// 
			this.buttonMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMoveUp.Image = global::DayTracker.Properties.Resources.bullet_arrow_up;
			this.buttonMoveUp.Location = new System.Drawing.Point(3, 61);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(23, 23);
			this.buttonMoveUp.TabIndex = 9;
			this.buttonMoveUp.UseVisualStyleBackColor = true;
			this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
			// 
			// buttonRemove
			// 
			this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRemove.Image = global::DayTracker.Properties.Resources.delete;
			this.buttonRemove.Location = new System.Drawing.Point(3, 32);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(23, 23);
			this.buttonRemove.TabIndex = 8;
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdd.Image = global::DayTracker.Properties.Resources.add;
			this.buttonAdd.Location = new System.Drawing.Point(3, 3);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(23, 23);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonDemote
			// 
			this.buttonDemote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDemote.Image = global::DayTracker.Properties.Resources.hourglass_delete;
			this.buttonDemote.Location = new System.Drawing.Point(3, 148);
			this.buttonDemote.Name = "buttonDemote";
			this.buttonDemote.Size = new System.Drawing.Size(23, 23);
			this.buttonDemote.TabIndex = 12;
			this.buttonDemote.UseVisualStyleBackColor = true;
			this.buttonDemote.Visible = false;
			this.buttonDemote.Click += new System.EventHandler(this.buttonDemote_Click);
			// 
			// flowLayout
			// 
			this.flowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayout.Controls.Add(this.buttonAdd);
			this.flowLayout.Controls.Add(this.buttonRemove);
			this.flowLayout.Controls.Add(this.buttonMoveUp);
			this.flowLayout.Controls.Add(this.buttonMoveDown);
			this.flowLayout.Controls.Add(this.buttonPromote);
			this.flowLayout.Controls.Add(this.buttonDemote);
			this.flowLayout.Location = new System.Drawing.Point(194, 0);
			this.flowLayout.Name = "flowLayout";
			this.flowLayout.Size = new System.Drawing.Size(29, 199);
			this.flowLayout.TabIndex = 13;
			// 
			// TaskList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayout);
			this.Controls.Add(this.listTasks);
			this.Name = "TaskList";
			this.Size = new System.Drawing.Size(223, 199);
			this.Load += new System.EventHandler(this.TaskList_Load);
			this.Resize += new System.EventHandler(this.TaskList_Resize);
			this.flowLayout.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonMoveDown;
		private System.Windows.Forms.Button buttonMoveUp;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.ListView listTasks;
		private System.Windows.Forms.ColumnHeader columnDescription;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonPromote;
		private System.Windows.Forms.Button buttonDemote;
		private System.Windows.Forms.FlowLayoutPanel flowLayout;
	}
}
