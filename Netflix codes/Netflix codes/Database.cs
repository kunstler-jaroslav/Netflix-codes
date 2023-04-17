using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace Netflix_codes
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Code>();
        }

        public Task<List<Code>> GetCodesAsync()
        {
            return _database.Table<Code>().ToListAsync();
        }

        public Task<int> SaveCodeAsync(Code person)
        {
            return _database.InsertAsync(person);
        }

        public async Task RemoveCodeAsync(int id)
        {
            await _database.DeleteAsync<Code>(id);
        }

        public Task<int> RemoveAllAsync()
        {
            return _database.DeleteAllAsync<Code>();
        }
    }
}
