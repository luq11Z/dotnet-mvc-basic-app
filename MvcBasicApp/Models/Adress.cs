using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasicApp.Models
{
    public class Adress : Entity 
    {
        public Guid ProviderId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(200, ErrorMessage = "The field {0} must be {2} and {1} characters", MinimumLength = 2)]
        [DisplayName("Public Place")]
        public string PublicPlace { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(50, ErrorMessage = "The field {0} must be {2} and {1} characters", MinimumLength = 2)]
        public string Number { get; set; }

        public string Complement { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(8, ErrorMessage = "The field {0} must be {1} characters", MinimumLength = 8)]
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100, ErrorMessage = "The field {0} must be {2} and {1} characters", MinimumLength = 2)]
        public string District { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100, ErrorMessage = "The field {0} must be {2} and {1} characters", MinimumLength = 2)]
        public string City { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(50, ErrorMessage = "The field {0} must be {2} and {1} characters", MinimumLength = 2)]
        public string State { get; set; }

        /* EF Relation */
        public Provider Provider { get; set; }
    }
}
