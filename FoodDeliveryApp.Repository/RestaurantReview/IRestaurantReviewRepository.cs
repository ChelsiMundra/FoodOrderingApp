using FoodDeliveryApp.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.RestaurantReview
{
    public interface IRestaurantReviewRepository
    {
        Task<IEnumerable<Review>> GetReviews();
        Task<Review> GetReview(int id);

        Task<Review> CreateReview(Review review);

        Task UpdateReview(Review review);

        Task DeleteReview(int id);
    }
}
