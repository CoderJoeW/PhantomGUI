using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PhantomGUI
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        [DllImport("user32.dll", EntryPoint = "SetProcessDPIAware")]
        private static extern bool SetProcessDPIAware();
    }
}
