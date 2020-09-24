using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhantomGUI.Helpers
{
    public static class Library
    {
        public static string CreatePhantomExecutable()
        {
            string tempExeName = Contants.GetPhantomExecutableLocation();

            using (FileStream fsDst = new FileStream(tempExeName, FileMode.CreateNew, FileAccess.Write))
            {
                byte[] bytes = GetPhantomExe();

                fsDst.Write(bytes, 0, bytes.Length);
            }

            return tempExeName;
        }

        public static void DeletePhantomExecutable()
        {
            File.Delete(Contants.GetPhantomExecutableLocation());
        }

        private static byte[] GetPhantomExe()
        {
            return Properties.Resources.phantom;
        }
    }
}
