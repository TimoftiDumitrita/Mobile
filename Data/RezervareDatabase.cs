using Mobile.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Data
{
    public class RezervareDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public RezervareDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Rezervare>().Wait();
        }
        public Task<List<Rezervare>> GetShopListsAsync() { return _database.Table<Rezervare>().ToListAsync(); }
        public Task<Rezervare> GetShopListAsync(int id) { return _database.Table<Rezervare>().Where(i => i.ID == id).FirstOrDefaultAsync(); }
        public Task<int> SaveShopListAsync(Rezervare srezervare)
        {
            if (srezervare.ID != 0)
            {
                return _database.UpdateAsync(srezervare);
            }
            else { return _database.InsertAsync(srezervare); }
        }
        public Task<int> DeleteShopListAsync(Rezervare srezervare) { return _database.DeleteAsync(srezervare); }
    }
}
