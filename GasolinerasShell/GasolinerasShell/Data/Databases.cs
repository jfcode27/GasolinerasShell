using GasolinerasShell.Extensions;
using GasolinerasShell.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolinerasShell.Data
{
    public class Databases
    {

        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() => {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;

        static bool initialized = false;

        public Databases()
        {
            InitializeAsync().SafeFireAndForget(false);
        }


        public async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(ShellModel).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(ShellModel)).ConfigureAwait(false);
                    initialized = true;
                }
            }
        }

        public  Task<List<ShellModel>> GetAllStationsAsync()
        {
            return Database.Table<ShellModel>().ToListAsync();
        }
    }
}
