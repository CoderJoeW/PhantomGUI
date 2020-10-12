using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhantomGUI.Models
{
    public class PhantomInfo
    {
        [SQLite.AutoIncrement] [SQLite.PrimaryKey]
        public int id { set; get; }

        public string server_name { set; get; }

        public string server_address { set; get; }

        public string server_port { set; get; }

        public string worker_threads { set; get; }

        public bool ipv6 { get; set; }

        public bool debug { get; set; }

        public bool remove_ports { get; set; }

        public string timeout { get; set; }

        public string bind { get; set; }

        public string bind_port { get; set; }
    }
}
