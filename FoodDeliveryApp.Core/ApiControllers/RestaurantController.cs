using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliveryApp.DomainModel.Models;
using FoodDeliveryApp.Repository.RestaurantRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryApp.Core.ApiControllers
{

    [ApiController]
    public class RestaurantController : Controller
    {
        private IRestaurantRepository _restaurantdata { get; set; }

        public RestaurantController(IRestaurantRepository restaurantdata) 
        {
            _restaurantdata = restaurantdata;
        }

        [HttpGet]
        [Route("api/Restaurant")]

        public IActionResult  GetRestaurants()//List
        {
            return Ok(_restaurantdata.GetRestaurants());
        }

        [HttpGet]
        [Route("api/Restaurant/{id}")]
        public IActionResult GetRestaurant(int id) //Single Res
        {
            var restaurant_detail = _restaurantdata.GetRestaurant(id);
            if (restaurant_detail != null)
            {
                return Json(restaurant_detail);
            }
            return NotFound($"Employee with Id : {id} was not found ");
        }

        [HttpPost]
        [Route("api/restaurant/add")]
        public IActionResult GetRestaurant([FromBody] Restaurant res ) //Add Restaurant
        {
            _restaurantdata.AddRestaurant(res);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + res.Id, res);
        }

        [HttpDelete]
        [Route("api/restaurant/delete/{id}")]
        public IActionResult DeleteRestaurant(int id) //Delete Restaurant
        {
           var restaurant = _restaurantdata.GetRestaurant(id);
           if(restaurant !=null)
            {
                _restaurantdata.DeleteRestaurant(restaurant);
                return Ok();
            }
            return NotFound($"Restaurant with Id : {id} was not found ");
        }

        [HttpPut]
        [Route("api/restaurant/edit/{id}")]
        public IActionResult EditRestaurant(int id,[FromBody]Restaurant res) //Edit Restaurant
        {
            var existing_restaurant = _restaurantdata.GetRestaurant(id);
            if (existing_restaurant != null)
            {
                res.Id = existing_restaurant.Id;
                _restaurantdata.EditRestaurant(res);

                return Ok(res);
            }
            return NotFound($"Restaurant with Id : {id} was not found ");
        }


    }
}
