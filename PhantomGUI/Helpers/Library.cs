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
            string result;
            string phantomParameters = string.Format($"--server {pi.server_address}:{pi.server_port} --workers {pi.worker_threads}");
            StringBuilder phantomOptions = new StringBuilder();

            if (!string.IsNullOrEmpty(pi.timeout) && pi.timeout != "60")
                phantomOptions.AppendFormat($" --timeout {pi.timeout}");

            if (pi.ipv6)
                phantomOptions.AppendFormat($" --6={pi.ipv6.ToString().ToLower()}");
           
            if (pi.debug)
                phantomOptions.AppendFormat($" --debug={pi.debug.ToString().ToLower()}");

            if (pi.remove_ports)
                phantomOptions.AppendFormat($" --remove_ports={pi.remove_ports.ToString().ToLower()}");

            if (!string.IsNullOrEmpty(pi.bind))
                phantomOptions.AppendFormat($" --bind \"{pi.bind}\"");

            if (!string.IsNullOrEmpty(pi.bind_port))
                phantomOptions.AppendFormat($" --bind_port {pi.bind_port}");

            if (phantomOptions.Length > 0)
                result = string.Format($"{phantomOptions} {phantomParameters}");
            else
                result = phantomParameters;

            return result;
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
