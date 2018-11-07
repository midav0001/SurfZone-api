using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SurfZone.DataAccess.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public Status Status { get; set; }

        public DateTime DateTime { get; set; }

    }
}
