﻿using System.Collections.Generic;

namespace MvcBasicApp.Models
{
    public class Provider : Entity
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public ProviderType ProviderType { get; set; }
        public Adress Adress { get; set; }
        public bool IsActive { get; set; }

        /* EF Relation */
        public IEnumerable<Product> Products { get; set; }
    }
}
