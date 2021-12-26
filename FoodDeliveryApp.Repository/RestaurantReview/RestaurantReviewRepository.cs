using FoodDeliveryApp.DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.RestaurantReview
{
    public class RestaurantReviewRepository : IRestaurantReviewRepository
    {
        private DataContext _dataContext;

        public RestaurantReviewRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Review> CreateReview(Review review)
        {
            _dataContext.Reviews.Add(review);
            await _dataContext.SaveChangesAsync();

            return review;
        }

        public async Task DeleteReview(int id)
        {
            var reviewTodelete = await _dataContext.Reviews.FindAsync(id);
            _dataContext.Reviews.Remove(reviewTodelete);
            

            await _dataContext.SaveChangesAsync();
        }

        public async  Task<Review> GetReview(int id)
        {
            return await _dataContext.Reviews.FindAsync(id);
        }

        public async  Task<IEnumerable<Review>> GetReviews()
        {
            return await _dataContext.Reviews.ToListAsync();
        }

        public async Task UpdateReview(Review review)
        {
            _dataContext.Entry(review).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();
        }


    }
}
