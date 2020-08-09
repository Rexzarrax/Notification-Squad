using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Notification_Squad
{
	class sql_access
	{
		MySqlConnection SQLConn;

		public readonly List<string> statusList;
		public readonly List<User> userList;

		public sql_access(string cs)
		{
			statusList = new List<string>();
			userList = new List<User>();

			SQLConn = new MySqlConnection(cs);
            try
            {
				SQLConn.Open();
				Console.WriteLine(SQLConn.ServerVersion.ToString());
			}
            catch
            {
				throw new Exception("Database Connection Error");
			}

		}
		public void ReopenConnections()
        {
            try
            {
				SQLConn.Close();
				SQLConn.Open();
			}
            catch
            {
				throw new Exception("Database Connection Error");
			}
		}
		//update the status of the user on the database.
		public void SetStatus(string name, int status_id)
		{
			string sqlstatement = String.Format("update notification_squad.user_names set notification_squad.user_names.status_id = {1} where name = '{0}';", name, status_id) ;
			Console.WriteLine(sqlstatement);
			ReopenConnections();
			MySqlCommand cmd = new MySqlCommand(sqlstatement, SQLConn);
			cmd.ExecuteNonQuery();
			SQLConn.Close();
		}
		//get the status table, used to populate names of buttons
		public void GetStatusAll()
		{
			string sqlstatement = "SELECT * FROM status;";
			ReopenConnections();
			MySqlCommand cmd = new MySqlCommand(sqlstatement, SQLConn);
			MySqlDataReader rdr = cmd.ExecuteReader();

			while (rdr.Read())
			{
				ReadSingleRow((IDataRecord)rdr);
			}

			// Call Close when done reading.
			rdr.Close();
		}

		private void ReadSingleRow(IDataRecord record)
		{
			Console.WriteLine(String.Format("{0}, {1}", record[0], record[1]));
			statusList.Add(record[1].ToString());
		}

		public void GetUserStatusAll()
        {
			ReopenConnections();
			userList.Clear();
			string sqlstatement = "SELECT user_names.name,status.status_name FROM notification_squad.user_names INNER JOIN notification_squad.status ON user_names.status_id = status.status_id ORDER BY user_names.name ASC;";
			MySqlCommand cmd = new MySqlCommand(sqlstatement, SQLConn);
			MySqlDataReader rdr = cmd.ExecuteReader();
			int i = 0;
			while (rdr.Read())
			{
				Console.WriteLine("{0} {1}", rdr.GetString(0), rdr.GetString(1));
				userList.Add(new User(rdr.GetString(0), rdr.GetString(1)));
				i++;

			}
			rdr.Close();
		}

	}
	struct User
    {
		public string name;
		public string status;
		
		public User (string Name, string Status)
        {
			name = Name;
			status = Status;
        }
	}
}
