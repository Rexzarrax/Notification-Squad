using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Squad
{
    class ReadHost
    {
        private string Hostname = "";

        public ReadHost()
        {
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"./host.txt");

            Hostname = lines[0];
        }
        public string Get()
        {
            return Hostname;
        }
    }
}
