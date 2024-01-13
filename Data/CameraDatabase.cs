using Mobile.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mobile.Data
{
    public class CameraDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public CameraDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Camera>().Wait();
        }
        public Task<List<Camera>> GetCamereAsync()
        {
            return _database.Table<Camera>().ToListAsync();
        }
        public Task<Camera> GetCamereAsync(int id)
        {
            return _database.Table<Camera>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCamereAsync(Camera camera)
        {
            if (camera.ID != 0)
            {
                return _database.UpdateAsync(camera);


            }

            else
            {
                return _database.InsertAsync(camera);
            }
        }
        public Task<int> DeleteCamereAsync(Camera camera)
        {
            return _database.DeleteAsync(camera);
        }

    }
}

