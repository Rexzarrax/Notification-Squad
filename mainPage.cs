using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
			string cs = @"server=" + RH.Get() + ";userid=NS_USER;password=Coast-Hard-Complicate-Rate-9;database=notification_squad";

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

			foreach(string status in SQL.statusList)
            {
				if(status != "Clear")
                {
					comboBox_status.Items.Add(status);
				}

            }

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

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
			All_button_actions(comboBox_status.SelectedIndex+1);

		}
    }

}
