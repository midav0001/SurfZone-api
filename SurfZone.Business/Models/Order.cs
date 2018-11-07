using System;
using System.Diagnostics;

namespace SurfZone.Business.Models
{
    public class Order
    {
        public int Id { get; set; }

        //public User {get; set;}

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }

        public OrderStatus Status { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdatedTime { get; set; }
    }
}