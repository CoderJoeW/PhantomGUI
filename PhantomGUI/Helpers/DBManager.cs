using SQLite;

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using PhantomGUI.Models;
using PhantomGUI.Extensions;

namespace PhantomGUI.Helpers
{
    public class DBManager
    {
        private static readonly Lazy<SQLiteAsyncConnection> lazy_initializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(PhantomGUI.Contants.DatabasePath, PhantomGUI.Contants.FLAGS);
        });

        static SQLiteAsyncConnection Database => lazy_initializer.Value;
        private static bool initialized = false;

        public DBManager()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        private async Task InitializeAsync()
        {
            if (!initialized)
            {
                if(!Database.TableMappings.Any(m => m.MappedType.Name == typeof(PhantomInfo).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(PhantomInfo)).ConfigureAwait(false);
                }

                initialized = true;
            }
        }

        public async Task<List<PhantomInfo>> GetPhantomInfosAsync()
        {
            return await Database.Table<PhantomInfo>().ToListAsync();
        }

        public Task<List<PhantomInfo>> DoPhantomInfoQuery(string query)
        {
            return Database.QueryAsync<PhantomInfo>(query);
        }

        public Task<PhantomInfo> GetPhantomInfoAsync(int id)
        {
            return Database.Table<PhantomInfo>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SavePhantomInfoAsync(PhantomInfo phantom_info)
        {
            PhantomInfo existing_phantom_info = GetPhantomInfoAsync(phantom_info.id).Result;

            if (existing_phantom_info == null)
            {
                return Database.InsertAsync(phantom_info);
            }
            else
            {
                return Database.UpdateAsync(phantom_info);
            }
        }

        public Task<int> DeletePhantomInfoAsync(int id)
        {
            return Database.DeleteAsync<PhantomInfo>(id);
        }
    }
}
