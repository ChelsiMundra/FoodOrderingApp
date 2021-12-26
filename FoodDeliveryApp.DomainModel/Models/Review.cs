using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.DomainModel.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }


        public int RestaurantId {get;set;}
        [ForeignKey("RestaurantId")]
        public Restaurant Restaurant { get; set; }

        public float Rating { get; set; }
        public string Review_Content { get; set; }
        public int Likes { get; set; }
        public bool IsComment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
