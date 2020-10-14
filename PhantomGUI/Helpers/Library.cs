using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhantomLib.Models;

namespace PhantomGUI.Helpers
{
    public static class Library
    {
        public static string CreateParametersString(PhantomInfo pi)
        {
            string result;
            string phantomParameters = string.Format($"--server {pi.ServerAddress}:{pi.ServerPort} --workers {pi.WorkerThreads}");
            StringBuilder phantomOptions = new StringBuilder();

            if (!string.IsNullOrEmpty(pi.Timeout) && pi.Timeout != "60")
                phantomOptions.AppendFormat($" --timeout {pi.Timeout}");

            if (pi.Ipv6)
                phantomOptions.AppendFormat($" --6={pi.Ipv6.ToString().ToLower()}");
           
            if (pi.Debug)
                phantomOptions.AppendFormat($" --debug={pi.Debug.ToString().ToLower()}");

            if (pi.RemovePorts)
                phantomOptions.AppendFormat($" --remove_ports={pi.RemovePorts.ToString().ToLower()}");

            if (!string.IsNullOrEmpty(pi.Bind))
                phantomOptions.AppendFormat($" --bind \"{pi.Bind}\"");

            if (!string.IsNullOrEmpty(pi.BindPort))
                phantomOptions.AppendFormat($" --bind_port {pi.BindPort}");

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
