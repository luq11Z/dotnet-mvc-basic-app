using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasicApp.Models
{
    public class Adress : Entity 
    {
        public Guid ProviderId { get; set; }

        public string PublicPlace { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string PostalCode { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        /* EF Relation */
        public Provider Provider { get; set; }
    }
}
