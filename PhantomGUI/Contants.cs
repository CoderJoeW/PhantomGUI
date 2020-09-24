using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhantomGUI
{
    public static class Contants
    {
        public static string GetPhantomExecutableLocation()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "phantom.exe");
        }
    }
}
