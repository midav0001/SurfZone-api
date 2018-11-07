using SurfZone.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurfZone.Api.DTO
{
    public class OrderDTO
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