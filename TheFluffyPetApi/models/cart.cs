using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheFluffyPetApi.models
{
    public class Cart
    {
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public float Discount { get; set; }
    }
}