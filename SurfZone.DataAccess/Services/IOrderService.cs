using System;
using System.Collections.Generic;
using System.Text;
using SurfZone.DataAccess.Models;

namespace SurfZone.DataAccess.Services
{
    public interface IOrderService
    {

        Order Get(int orderId);
        IEnumerable<Order> GetAll();
        IEnumerable<Order> GetAllForUser(int userId);
        void UpdateStatus(int orderId, Status status);
        void Create(Order order);

    }
}
