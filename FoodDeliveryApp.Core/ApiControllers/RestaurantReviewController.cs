using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using FoodDeliveryApp.Repository.RestaurantReview;
using FoodDeliveryApp.DomainModel.Models;

namespace FoodDeliveryApp.Core.ApiControllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantReviewController : ControllerBase
    {
        private IRestaurantReviewRepository _restaurantReviewRepository;

        public RestaurantReviewController(IRestaurantReviewRepository restaurantReviewRepository)
        {
            _restaurantReviewRepository = restaurantReviewRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Review>> GetReviews()
        {
            return await _restaurantReviewRepository.GetReviews();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReview(int id)
        {
            return await _restaurantReviewRepository.GetReview(id);
        }
        [HttpPost]
        public async Task<ActionResult<Review>> PostReview([FromBody] Review review)
        {
            var newReview = await _restaurantReviewRepository.CreateReview(review);
            return CreatedAtAction(nameof(GetReview), new { id = newReview.Id }, newReview);
        }

        [HttpPut]
        public async Task<IActionResult> PutReview(int id, [FromBody] Review review)
        {
            if (id != review.Id)
            {
                return BadRequest();
            }
            await _restaurantReviewRepository.UpdateReview(review);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var reviewToDelete = await _restaurantReviewRepository.GetReview(id);
            if (reviewToDelete == null)
            {
                return NotFound();
            }

            await _restaurantReviewRepository.DeleteReview(reviewToDelete.Id);
            return NoContent();

        }
    }
}
