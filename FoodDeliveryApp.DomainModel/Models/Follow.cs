using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.DomainModel.Models
{
    public class Follow
    {
        [Key]
        public int Id { get; set; }
        public int FollowerId { get; set; }
        [ForeignKey("FollwerId")]

        public User UserW { get; set; }
        public int FollowedById { get; set; }
        [ForeignKey("FollowById")]
        public User UserB { get; set; }

        
    }
}
