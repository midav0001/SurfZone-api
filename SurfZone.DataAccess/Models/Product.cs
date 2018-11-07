using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SurfZone.DataAccess.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public int? OrderId { get; set; }

        public Order Order { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public (string, string) Details { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }


    }
}
