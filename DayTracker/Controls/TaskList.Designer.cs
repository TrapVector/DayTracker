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
			this.buttonMoveDown = new System.Windows.Forms.Button();
			this.buttonMoveUp = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.listTasks = new System.Windows.Forms.ListView();
			this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonMoveDown
			// 
			this.buttonMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMoveDown.Image = global::DayTracker.Properties.Resources.bullet_arrow_down;
			this.buttonMoveDown.Location = new System.Drawing.Point(308, 90);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(23, 23);
			this.buttonMoveDown.TabIndex = 10;
			this.buttonMoveDown.UseVisualStyleBackColor = true;
			// 
			// buttonMoveUp
			// 
			this.buttonMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMoveUp.Image = global::DayTracker.Properties.Resources.bullet_arrow_up;
			this.buttonMoveUp.Location = new System.Drawing.Point(308, 61);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(23, 23);
			this.buttonMoveUp.TabIndex = 9;
			this.buttonMoveUp.UseVisualStyleBackColor = true;
			// 
			// buttonRemove
			// 
			this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRemove.Image = global::DayTracker.Properties.Resources.delete;
			this.buttonRemove.Location = new System.Drawing.Point(308, 32);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(23, 23);
			this.buttonRemove.TabIndex = 8;
			this.buttonRemove.UseVisualStyleBackColor = true;
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
			this.listTasks.Size = new System.Drawing.Size(299, 328);
			this.listTasks.TabIndex = 7;
			this.listTasks.UseCompatibleStateImageBehavior = false;
			this.listTasks.View = System.Windows.Forms.View.Details;
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
			this.buttonAdd.Location = new System.Drawing.Point(308, 3);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(23, 23);
			this.buttonAdd.TabIndex = 6;
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// TaskList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonMoveDown);
			this.Controls.Add(this.buttonMoveUp);
			this.Controls.Add(this.buttonRemove);
			this.Controls.Add(this.listTasks);
			this.Controls.Add(this.buttonAdd);
			this.Name = "TaskList";
			this.Size = new System.Drawing.Size(334, 334);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonMoveDown;
		private System.Windows.Forms.Button buttonMoveUp;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.ListView listTasks;
		private System.Windows.Forms.ColumnHeader columnDescription;
		private System.Windows.Forms.Button buttonAdd;
	}
}
