using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliveryApp.DomainModel.Models;
using FoodDeliveryApp.Repository.CategoryRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryApp.Core.ApiControllers
{

    [ApiController]
    public class CategoryController : Controller
    {
        private ICategoryRepository _categorydata { get; set; }

        public CategoryController(ICategoryRepository categorydata)
        {
            _categorydata = categorydata;
        }

        [HttpGet]
        [Route("api/Category")]

        public IActionResult GetCategories()//List
        {
            return Ok(_categorydata.GetCategories());
        }

        [HttpGet]
        [Route("api/Category/{id}")]
        public IActionResult GetCategory(int id) //Single category
        {
            var category_detail = _categorydata.GetCategory(id);
            if (category_detail != null)
            {
                return Json(category_detail);
            }
            return NotFound($"Category with Id : {id} was not found ");
        }

        [HttpPost]
        [Route("api/category")]
        public IActionResult GetCategory([FromBody] Category category) //Add Category
        {
            _categorydata.AddCategory(category);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Path + "/" + category.Id, category);
        }

        [HttpDelete]
        [Route("api/category/delete/{id}")]
        public IActionResult DeleteCategory(int id) //Delete Category
        {
            var category = _categorydata.GetCategory(id);
            if (category != null)
            {
                _categorydata.DeleteCategory(category);
                return Ok();
            }
            return NotFound($"Category with Id : {id} was not found ");
        }

        [HttpPut]
        [Route("api/category/edit/{id}")]
        public IActionResult EditCategory(int id, [FromBody] Category category) //Edit Category
        {
            var existing_category = _categorydata.GetCategory(id);
            if (existing_category != null)
            {
                category.Id = existing_category.Id;
                _categorydata.EditCategory(category);
                return Ok(category);
            }
            return NotFound($"Category with Id : {id} was not found ");
        }


    }
}
