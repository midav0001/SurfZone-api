using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SurfZone.DataAccess.Models;

namespace SurfZone.DataAccess.Services
{
    public class OrderService : IOrderService
    {
        private readonly SurfZoneContext dbContext;

        public OrderService()
        {
            this.dbContext = new SurfZoneContext();
        }

        public void Create(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }

        public Order Get(int orderId)
        {
            var order = dbContext.Orders.Find(orderId);
            return order;
        }

        public IEnumerable<Order> GetAll()
        {
            return dbContext.Orders;
        }

        public IEnumerable<Order> GetAllForUser(int userId)
        {
            return dbContext.Orders.Where(o => o.UserId == userId);
        }

        public void UpdateStatus(int orderId, Status status)
        {
            var order = dbContext.Orders.Find(orderId);
            if (order != null)
            {
                order.Status = status;
                dbContext.SaveChanges();
            }
        }
    }
}
