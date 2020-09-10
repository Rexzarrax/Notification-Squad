namespace Notification_Squad_DNC
{
    partial class mainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_autoreload = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_available_percentage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_db_type = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel_status = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_autoreload
            // 
            this.timer_autoreload.Enabled = true;
            this.timer_autoreload.Interval = 5000;
            this.timer_autoreload.Tick += new System.EventHandler(this.Timer_Autoreload_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_available_percentage,
            this.toolStripStatusLabel_db_type});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(256, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_available_percentage
            // 
            this.toolStripStatusLabel_available_percentage.Name = "toolStripStatusLabel_available_percentage";
            this.toolStripStatusLabel_available_percentage.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel_available_percentage.Text = "[percentage]";
            // 
            // toolStripStatusLabel_db_type
            // 
            this.toolStripStatusLabel_db_type.Name = "toolStripStatusLabel_db_type";
            this.toolStripStatusLabel_db_type.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel_db_type.Text = "[connection]";
            // 
            // flowLayoutPanel_status
            // 
            this.flowLayoutPanel_status.Location = new System.Drawing.Point(0, -1);
            this.flowLayoutPanel_status.Name = "flowLayoutPanel_status";
            this.flowLayoutPanel_status.Size = new System.Drawing.Size(256, 364);
            this.flowLayoutPanel_status.TabIndex = 1;
            // 
            // comboBox_status
            // 
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(12, 369);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(244, 23);
            this.comboBox_status.TabIndex = 2;
            this.comboBox_status.SelectedIndexChanged += new System.EventHandler(this.comboBox_status_SelectedIndexChanged);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 417);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.flowLayoutPanel_status);
            this.Controls.Add(this.statusStrip1);
            this.Name = "mainPage";
            this.Text = "Notification Squad";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_autoreload;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_available_percentage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_db_type;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_status;
        private System.Windows.Forms.ComboBox comboBox_status;
    }
}

