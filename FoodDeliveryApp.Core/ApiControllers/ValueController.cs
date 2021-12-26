using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace FoodDeliveryApp.Core.ApiControllers
{

    
    [ApiController]
    public class ValueController : ControllerBase
    {
        [HttpGet("/api/values")]
        public IActionResult Get()
        {
            return Ok(new string[] { "a", "b", "c", "d", "e" });

        }
    }
}
