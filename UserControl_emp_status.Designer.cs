namespace Notification_Squad_DNC
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.checkBox_Selected_to_change = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(-1, -1);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(120, 23);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(116, -1);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.ReadOnly = true;
            this.textBox_status.Size = new System.Drawing.Size(100, 23);
            this.textBox_status.TabIndex = 1;
            // 
            // checkBox_Selected_to_change
            // 
            this.checkBox_Selected_to_change.AutoSize = true;
            this.checkBox_Selected_to_change.Location = new System.Drawing.Point(221, 3);
            this.checkBox_Selected_to_change.Name = "checkBox_Selected_to_change";
            this.checkBox_Selected_to_change.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Selected_to_change.TabIndex = 2;
            this.checkBox_Selected_to_change.UseVisualStyleBackColor = true;
            // 
            // UserControl_emp_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.checkBox_Selected_to_change);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.textBox_name);
            this.Name = "UserControl_emp_status";
            this.Size = new System.Drawing.Size(245, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox_Selected_to_change;
        private System.Windows.Forms.TextBox textBox_status;
    }
}
