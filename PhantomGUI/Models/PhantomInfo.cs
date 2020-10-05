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
    }
}
