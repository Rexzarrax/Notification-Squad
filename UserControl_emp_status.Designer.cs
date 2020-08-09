namespace Notification_Squad
{
	partial class UserControl_emp_status
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.checkBox_Selected_to_change = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_status
            // 
            this.textBox_status.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_status.Enabled = false;
            this.textBox_status.Location = new System.Drawing.Point(106, 9);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.ReadOnly = true;
            this.textBox_status.Size = new System.Drawing.Size(85, 20);
            this.textBox_status.TabIndex = 3;
            // 
            // textBox_name
            // 
            this.textBox_name.Enabled = false;
            this.textBox_name.Location = new System.Drawing.Point(3, 9);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(97, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // checkBox_Selected_to_change
            // 
            this.checkBox_Selected_to_change.AutoSize = true;
            this.checkBox_Selected_to_change.Location = new System.Drawing.Point(197, 11);
            this.checkBox_Selected_to_change.Name = "checkBox_Selected_to_change";
            this.checkBox_Selected_to_change.Size = new System.Drawing.Size(56, 17);
            this.checkBox_Selected_to_change.TabIndex = 5;
            this.checkBox_Selected_to_change.Text = "Select";
            this.checkBox_Selected_to_change.UseVisualStyleBackColor = true;
            // 
            // UserControl_emp_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.checkBox_Selected_to_change);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_status);
            this.Name = "UserControl_emp_status";
            this.Size = new System.Drawing.Size(261, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox_status;
		private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.CheckBox checkBox_Selected_to_change;
    }
}
