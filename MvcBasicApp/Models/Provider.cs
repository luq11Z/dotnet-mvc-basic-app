using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcBasicApp.Models
{
    public class Provider : Entity
    {
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100, ErrorMessage = "The field {0} must be {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(14, ErrorMessage = "The field {0} must be {2} and {1} characters", MinimumLength = 11)]
        public string Document { get; set; }

        [DisplayName("Provider Type")]
        public ProviderType ProviderType { get; set; }

        public Adress Adress { get; set; }

        [DisplayName("Active?")]
        public bool IsActive { get; set; }

        /* EF Relation */
        public IEnumerable<Product> Products { get; set; }
    }
}
