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
        public const string DATABASE_FILENAME = "LocalDatabase.db3";

        public const SQLite.SQLiteOpenFlags FLAGS =
            //Open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            //Create the database if it doesnt exist
            SQLite.SQLiteOpenFlags.Create |
            //Enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                return Path.Combine(Directory.GetCurrentDirectory(), DATABASE_FILENAME);
            }
        }

        public static string GetPhantomExecutableLocation()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "phantom.exe");
        }
    }
}
