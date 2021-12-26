using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.DomainModel.Models
{
    public class BasicDetails
    {
     
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }


        public int CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public User UserC { get; set; }

        public int DeletedBy { get; set; }
        [ForeignKey("DeletedBy")]
        public User UserD { get; set; }


        public bool IsDeleted { get; set; }
    }
}
