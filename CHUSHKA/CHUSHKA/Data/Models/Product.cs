﻿namespace CHUSHKA.Data.Models
{
    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public ProductType Type { get; set; } 
        
        public virtual ICollection<Order> Orders { get; set; }

    }
}