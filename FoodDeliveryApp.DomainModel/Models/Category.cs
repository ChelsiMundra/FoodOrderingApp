using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.DomainModel.Models
{
   public class Category 
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName {get; set;}
        public int MenuId { get; set; }
        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsDeleted { get; set; }

    }
}
