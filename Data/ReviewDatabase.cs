﻿using Mobile.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Data
{
   
    
        public class ReviewDatabase
        {
            readonly SQLiteAsyncConnection _database;

            public ReviewDatabase(string dbPath)
            {
                _database = new SQLiteAsyncConnection(dbPath);
                _database.CreateTableAsync<Review>().Wait();
            }

            public Task<List<Review>> GetReviewsAsync() => _database.Table<Review>().ToListAsync();

            public Task<Review> GetReviewAsync(int id) => _database.Table<Review>().Where(i => i.ID == id).FirstOrDefaultAsync();

            public Task<int> SaveReviewAsync(Review review)
            {
            if (review != null)
            {
                if (review.ID != 0)
                {
                    return _database.UpdateAsync(review);
                }
                else
                {
                    return _database.InsertAsync(review);
                }
            }
            else
            {
              
                return Task.FromResult(0);
            }
        }

            public Task<int> DeleteReviewAsync(Review review) => _database.DeleteAsync(review);
        }
    }

