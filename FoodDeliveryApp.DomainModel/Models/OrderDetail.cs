using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.DomainModel.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public int DishId { get; set; }
        [ForeignKey("DishId")]
        public Dish Dish { get; set; }

        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

    }
}
