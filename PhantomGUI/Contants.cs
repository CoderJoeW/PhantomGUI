using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace PhantomGUI
{
    public static class Contants
    {
        public const string DatabaseFilename = "LocalDatabase.db3";

        public const SQLite.SQLiteOpenFlags FLAGS =
            //Open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            //Create the database if it doesnt exist
            SQLite.SQLiteOpenFlags.Create |
            //Enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath => 
            Path.Combine(Directory.GetCurrentDirectory(), DatabaseFilename);

        public static string GetPhantomExecutableLocation(string instance) => 
            Path.Combine(UserDataFolder, instance + "_phantom.exe");

        public static Guid AppGuid
        {
            get
            {
                Assembly asm = Assembly.GetEntryAssembly();
                object[] attr = asm.GetCustomAttributes(typeof(GuidAttribute), true);
                return new Guid((attr[0] as GuidAttribute).Value);
            }
        }

        public static string UserDataFolder
        {
            get
            {
                Guid appGuid = AppGuid;
                string folderBase = Environment.GetFolderPath
                                    (Environment.SpecialFolder.LocalApplicationData);
                string dir = $@"{folderBase}\{appGuid.ToString("B").ToUpper()}\";
                return CheckDir(dir);
            }
        }

        private static string CheckDir(string dir)
        {
            if (Directory.Exists(dir) == false)
                Directory.CreateDirectory(dir);
            return dir;
        }
    }
}
