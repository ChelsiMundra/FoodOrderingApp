using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.DomainModel.Models
{
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]

        public Category Category { get; set; }
        public string DishName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsDeleted { get; set; }


    }
}
