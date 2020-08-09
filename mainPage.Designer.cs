namespace Notification_Squad
{
	partial class mainPage
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_available_percentage = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel_status = new System.Windows.Forms.FlowLayoutPanel();
            this.button_select_1 = new System.Windows.Forms.Button();
            this.button_select_2 = new System.Windows.Forms.Button();
            this.button_select_3 = new System.Windows.Forms.Button();
            this.button_select_4 = new System.Windows.Forms.Button();
            this.timer_autoreload = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel_db_type = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_available_percentage,
            this.toolStripStatusLabel_db_type});
            this.statusStrip1.Location = new System.Drawing.Point(0, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(275, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_available_percentage
            // 
            this.toolStripStatusLabel_available_percentage.Name = "toolStripStatusLabel_available_percentage";
            this.toolStripStatusLabel_available_percentage.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel_available_percentage.Text = "[percentage]";
            // 
            // flowLayoutPanel_status
            // 
            this.flowLayoutPanel_status.AutoScroll = true;
            this.flowLayoutPanel_status.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_status.Name = "flowLayoutPanel_status";
            this.flowLayoutPanel_status.Size = new System.Drawing.Size(275, 341);
            this.flowLayoutPanel_status.TabIndex = 4;
            // 
            // button_select_1
            // 
            this.button_select_1.Location = new System.Drawing.Point(0, 345);
            this.button_select_1.Name = "button_select_1";
            this.button_select_1.Size = new System.Drawing.Size(59, 23);
            this.button_select_1.TabIndex = 5;
            this.button_select_1.Text = "[button]";
            this.button_select_1.UseVisualStyleBackColor = true;
            this.button_select_1.Click += new System.EventHandler(this.Button_select_1_Click);
            // 
            // button_select_2
            // 
            this.button_select_2.Location = new System.Drawing.Point(65, 345);
            this.button_select_2.Name = "button_select_2";
            this.button_select_2.Size = new System.Drawing.Size(78, 23);
            this.button_select_2.TabIndex = 6;
            this.button_select_2.Text = "[button]";
            this.button_select_2.UseVisualStyleBackColor = true;
            this.button_select_2.Click += new System.EventHandler(this.Button_select_2_Click);
            // 
            // button_select_3
            // 
            this.button_select_3.Location = new System.Drawing.Point(149, 345);
            this.button_select_3.Name = "button_select_3";
            this.button_select_3.Size = new System.Drawing.Size(59, 23);
            this.button_select_3.TabIndex = 7;
            this.button_select_3.Text = "[button]";
            this.button_select_3.UseVisualStyleBackColor = true;
            this.button_select_3.Click += new System.EventHandler(this.Button_select_3_Click);
            // 
            // button_select_4
            // 
            this.button_select_4.Location = new System.Drawing.Point(214, 345);
            this.button_select_4.Name = "button_select_4";
            this.button_select_4.Size = new System.Drawing.Size(61, 23);
            this.button_select_4.TabIndex = 8;
            this.button_select_4.Text = "[button]";
            this.button_select_4.UseVisualStyleBackColor = true;
            this.button_select_4.Click += new System.EventHandler(this.Button_select_4_Click);
            // 
            // timer_autoreload
            // 
            this.timer_autoreload.Enabled = true;
            this.timer_autoreload.Interval = 5000;
            this.timer_autoreload.Tick += new System.EventHandler(this.timer_autoreload_Tick);
            // 
            // toolStripStatusLabel_db_type
            // 
            this.toolStripStatusLabel_db_type.Name = "toolStripStatusLabel_db_type";
            this.toolStripStatusLabel_db_type.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel_db_type.Text = "[Connection]";
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 393);
            this.Controls.Add(this.button_select_4);
            this.Controls.Add(this.button_select_3);
            this.Controls.Add(this.button_select_2);
            this.Controls.Add(this.button_select_1);
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
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_available_percentage;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_status;
        private System.Windows.Forms.Button button_select_1;
        private System.Windows.Forms.Button button_select_2;
        private System.Windows.Forms.Button button_select_3;
        private System.Windows.Forms.Button button_select_4;
        private System.Windows.Forms.Timer timer_autoreload;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_db_type;
    }
}

