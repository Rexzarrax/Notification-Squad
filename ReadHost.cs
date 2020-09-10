using System.Windows.Forms;

namespace Notification_Squad_DNC
{
    class ReadHost
    {
        private readonly string Hostname = "";

        public ReadHost()
        {
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"./host.txt");
                Hostname = lines[0];
            }
            catch
            {
                MessageBox.Show("Error", "Missing host.txt");
                Application.Exit();
            }


        }
        public string Get()
        {
            return Hostname;
        }
    }
}
