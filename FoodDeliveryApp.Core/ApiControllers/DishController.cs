using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliveryApp.DomainModel.Models;
using FoodDeliveryApp.Repository.DishRepository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryApp.Core.ApiControllers
{

    [ApiController]
    public class DishController : Controller
    {
        private IDishRepository _dishdata { get; set; }

        public DishController(IDishRepository dishdata)
        {
            _dishdata = dishdata;
        }

        [HttpGet]
        [Route("api/dish")]

        public IActionResult GetDishes()//List
        {
            return Ok(_dishdata.GetDishes());
        }

        [HttpGet]
        [Route("api/dish/{id}")]
        public IActionResult GetDish(int id) //Single dish
        {
            var dish_detail = _dishdata.GetDish(id);
            if (dish_detail != null)
            {
                return Json(dish_detail);
            }
            return NotFound($"Dish with Id : {id} was not found ");
        }

        [HttpPost]
        [Route("api/dish")]
        public IActionResult GetDish([FromBody] Dish dish) //Add Dish
        {
            _dishdata.AddDish(dish);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + dish.Id, dish);
        }

        [HttpDelete]
        [Route("api/dish/delete/{id}")]
        public IActionResult DeleteDish(int id) //Delete Dish
        {
            var dish = _dishdata.GetDish(id);
            if (dish != null)
            {
                _dishdata.DeleteDish(dish);
                return Ok();
            }
            return NotFound($"Dish with Id : {id} was not found ");
        }

        [HttpPut]
        [Route("api/dish/edit/{id}")]
        public IActionResult EditDish(int id, [FromBody] Dish dish) //Edit Dish
        {
            var existing_dish = _dishdata.GetDish(id);
            if (existing_dish != null)
            {
                dish.Id = existing_dish.Id;
                _dishdata.EditDish(dish);
                return Ok(dish);
            }
            return NotFound($"Dish with Id : {id} was not found ");
        }


    }
}
