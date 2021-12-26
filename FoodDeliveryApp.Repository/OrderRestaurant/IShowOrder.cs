using FoodDeliveryApp.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.OrderRestaurant
{
    public interface IShowOrder
    {
        List<Order> GetOrderRecords();
    }
}
