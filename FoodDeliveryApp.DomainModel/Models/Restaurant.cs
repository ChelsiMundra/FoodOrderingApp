using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.DomainModel.Models
{
   public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public string ContactNumber { get; set; }
        public string Location { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public int CostForTwo { get; set; }
        public float Rating { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }


        public int CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public User UserC { get; set; }



        public int? DeletedBy { get; set; }
        [ForeignKey("DeletedBy")]
        public User UserD { get; set; }


        public bool IsDeleted { get; set; }

    }
}
