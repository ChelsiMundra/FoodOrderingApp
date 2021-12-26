using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using FoodDeliveryApp.DomainModel.Models;
using FoodDeliveryApp.Repository;
using FoodDeliveryApp.Repository.OrderRestaurant;

namespace FoodDeliveryApp.Core.ApiControllers
{

    
    [ApiController]
    public class ShowOrderController : ControllerBase
    {
        private readonly IShowOrder _order;
        public ShowOrderController(IShowOrder order)
        {
            _order = order;
        }


        [HttpGet("/api/values")]
        public IEnumerable<Order> Get()
        {
            return _order.GetOrderRecords();
        }

    }
}
