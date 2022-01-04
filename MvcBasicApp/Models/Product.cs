using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasicApp.Models
{
    public class Product : Entity
    {
        public Guid ProviderId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(200, ErrorMessage = "The field {0} must be {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(1000, ErrorMessage = "The field {0} must be {2} and {1} characters", MinimumLength = 2)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(200, ErrorMessage = "The field {0} must be {2} and {1} characters", MinimumLength = 2)]
        public string Image { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }

        [DisplayName("Active?")]
        public bool IsActive { get; set; }

        /*EF Relation*/
        public Provider Provider { get; set; }
    }
}
