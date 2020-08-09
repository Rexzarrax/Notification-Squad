using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media;
namespace Notification_Squad
{
	public partial class mainPage : Form
	{
		sql_access SQL;
		int reloadnum = 0;
		public mainPage()
		{
			InitializeComponent();

			ReadHost RH = new ReadHost();
			Console.WriteLine(RH.Get());
			string cs = @"server=" + RH.Get() + ";userid=NS_USER;password=;database=notification_squad";

            try
            {
				SQL = new sql_access(cs);
				SQL.GetStatusAll();
				SQL.GetUserStatusAll();
				LoadAll();
				toolStripStatusLabel_db_type.Text = "DB location: " + RH.Get();
			}
			catch
            {
				timer_autoreload.Stop();
				MessageBox.Show("Error connecting to Database", "Critical Error");
				Application.Exit();
				System.Environment.Exit(1);
			}
			
		}

		private void ReloadAll()
        {
			Console.WriteLine("Reloading - "+ reloadnum++);
			SQL.GetUserStatusAll();
			int availableCount = 0;
			for (int i = 0; i <= SQL.userList.Count()-1; i++)
			{
				flowLayoutPanel_status.Controls[i].Controls["textBox_name"].Text = SQL.userList[i].name;
				flowLayoutPanel_status.Controls[i].Controls["textBox_status"].Text = SQL.userList[i].status;


				if (SQL.userList[i].status == "Available")
				{
					availableCount++;
				}
			}
			GetPercentage(SQL.userList.Count(), availableCount);
		}

		public void LoadAll()
		{
			//Set the names of the buttons
			button_select_1.Text = SQL.statusList[0];
			button_select_2.Text = SQL.statusList[1];
			button_select_3.Text = SQL.statusList[2];
			button_select_4.Text = SQL.statusList[3];

			for (int i = 0; i < SQL.userList.Count(); i++)
			{
				flowLayoutPanel_status.Controls.Add(new UserControl_emp_status { Parent = flowLayoutPanel_status });
			}
			ReloadAll();
		}

		public void GetPercentage(int total, int countofavail)
        {
			double percentage = ((double)countofavail / total)*100;
			
			toolStripStatusLabel_available_percentage.Text = "Available: "+percentage.ToString()+"%";
		}

		private void All_button_actions(int status_id)
        {
			SQL.GetUserStatusAll();
			if (GetTicks().Count >= 1)
			{
				foreach (string name in GetTicks())
                {
					SQL.SetStatus(name, status_id);
				}
				ReloadAll();
			}
			else
			{
				MessageBox.Show("Please select a User","Error");
			}
		}

        private void Button_select_1_Click(object sender, EventArgs e)
        {
			All_button_actions(1);

		}

        private void Button_select_2_Click(object sender, EventArgs e)
        {
			All_button_actions(2);
		}

        private void Button_select_3_Click(object sender, EventArgs e)
        {
			All_button_actions(3);
		}

        private void Button_select_4_Click(object sender, EventArgs e)
        {
			All_button_actions(4);
		}

		private List<string> GetTicks()
        {
			List<string> checkedNames = new List<string>();
			foreach (Control control in flowLayoutPanel_status.Controls)
            {
				if (control.Controls.ContainsKey("checkBox_Selected_to_change"))
                {
					CheckBox checkBox = (CheckBox)control.Controls["checkBox_Selected_to_change"];
                    if (checkBox.Checked)
                    {
						checkedNames.Add(control.Controls["textBox_name"].Text);
						Console.WriteLine(checkedNames);
					}

				}
            }
			return checkedNames;

		}

        private void timer_autoreload_Tick(object sender, EventArgs e)
        {
			ReloadAll();
		}
    }

}
