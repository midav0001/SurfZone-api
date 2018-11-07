using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SurfZone.DataAccess.Services;
using SurfZone.DataAccess.Models;
using SurfZone.DataAccess;
using SurfZone.Api.DTO;
using AutoMapper;

namespace SurfZone.Api.Controllers
{
    public class OrderController : ApiController
    {
        private readonly IOrderService orderService;
        private readonly IMapper mapper;

        public OrderController()
        {
            this.orderService = new OrderService();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order, OrderDTO>().ReverseMap();
            });
            mapper = config.CreateMapper();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var orders = orderService.GetAll();
            var ordersDTO = orders.Select(p => mapper.Map<Order, OrderDTO>(p));
            return Ok(ordersDTO);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var order = orderService.Get(id);
            if (order == null)
            {
                return NotFound();
            }
            var orderDTO = mapper.Map<Order, OrderDTO>(order);
            return Ok(orderDTO);
        }

        [HttpPost]
        public IHttpActionResult Create(OrderDTO orderDTO)
        {
            if (orderDTO == null)
            {
                return BadRequest();
            }
            var order = mapper.Map<OrderDTO, Order>(orderDTO);
            orderService.Create(order);
            return Ok();
        }

        [HttpGet]
        [Route("api/{id}/order")]
        public IHttpActionResult GetAllForUser(int id)
        {
            var orders = orderService.GetAllForUser(id);
            if (orders == null)
            {
                return NotFound();
            }
            var ordersDTO = orders.Select(p => mapper.Map<Order, OrderDTO>(p));
            return Ok(ordersDTO);
        }

        [HttpPut]
        [Route("api/{id}/{status}/order")]
        public IHttpActionResult UpdateStatus(int id, Status status)
        {
            orderService.UpdateStatus(id, status);
            return Ok();
        }
    }
}
