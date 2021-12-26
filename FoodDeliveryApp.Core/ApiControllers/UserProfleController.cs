using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using FoodDeliveryApp.Repository.RestaurantReview;
using FoodDeliveryApp.DomainModel.Models;
using FoodDeliveryApp.Repository.UserProfile;

namespace FoodDeliveryApp.Core.ApiControllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private IUserProfileRepository _userProfileRepository;

        public UserProfileController(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }  

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userProfileRepository.GetUsers();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return  await _userProfileRepository.GetUser(id);
        }
        [HttpPost]
        public async Task<ActionResult<User>> PostUser([FromBody] User user)
        {
            var newUser = await _userProfileRepository.CreateUser(user);
            return CreatedAtAction(nameof(GetUsers), new { id = newUser.Id }, newUser);
        }

        [HttpPut]
        public async  Task<IActionResult>PutUser(int id,[FromBody] User user)
        {
            if(id != user.Id)
            {
                return BadRequest();
            }
            await _userProfileRepository.UpdateUser(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var userToDelete = await _userProfileRepository.GetUser(id);
            if(userToDelete == null)
            {
                return NotFound();
            }

            await _userProfileRepository.DeleteUser(userToDelete.Id);
            return NoContent();

        }
    }
}
