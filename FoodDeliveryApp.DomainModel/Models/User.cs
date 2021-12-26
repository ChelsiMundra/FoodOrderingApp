using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.DomainModel.Models
{
   public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email_Id { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public string IsDeletedBy { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
