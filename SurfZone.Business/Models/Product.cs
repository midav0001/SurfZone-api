using System;
using System.Collections.Generic;

namespace SurfZone.Business.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public List<ValueTuple<string,string>> Details { get; set; }
    }
}
