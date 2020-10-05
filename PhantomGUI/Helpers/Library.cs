using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhantomGUI.Models;

namespace PhantomGUI.Helpers
{
    public static class Library
    {
        public static string CreateParametersString(PhantomInfo pi)
        {
            string parameters = "--server " + pi.server_address + ":" + pi.server_port + " --workers " + pi.worker_threads;

            return parameters;
        }

        public static string CreatePhantomExecutable(string instance)
        {
            string tempExeName = Contants.GetPhantomExecutableLocation(instance);

            using (FileStream fsDst = new FileStream(tempExeName, FileMode.CreateNew, FileAccess.Write))
            {
                byte[] bytes = GetPhantomExe();

                fsDst.Write(bytes, 0, bytes.Length);
            }

            return tempExeName;
        }

        public static void DeletePhantomExecutable(string instance)
        {
            File.Delete(Contants.GetPhantomExecutableLocation(instance));
        }

        private static byte[] GetPhantomExe()
        {
            return Properties.Resources.phantom;
        }
    }
}
