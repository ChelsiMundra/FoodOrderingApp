using FoodDeliveryApp.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Repository.OrderRestaurant
{
   public class ShowOrder : IShowOrder
    {
        public readonly DataContext _context;
        public ShowOrder(DataContext context)
        {
            _context = context;
        }
        public List<Order> GetOrderRecords()
        {
            return _context.Orders.ToList();
        }
    }
}
