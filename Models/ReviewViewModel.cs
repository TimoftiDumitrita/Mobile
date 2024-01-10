using Mobile.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Models
{
    public class ReviewViewModel
    {
        public ObservableCollection<Review> Review { get; set; }

        public ReviewViewModel()
        {
            LoadReviews();
        }

        private async void LoadReviews()
        {
            var database = new ReviewDatabase("path_to_database");
            var reviews = await database.GetReviewsAsync();
            Review = new ObservableCollection<Review>(reviews);
        }

        public async Task SaveReviewAsync(Review review)
        {
            var database = new ReviewDatabase("path_to_database");
            await database.SaveReviewAsync(review);
            LoadReviews();
        }

        public async Task DeleteReviewAsync(Review review)
        {
            var database = new ReviewDatabase("path_to_database");
            await database.DeleteReviewAsync(review);
            LoadReviews();
        }

    }
}
