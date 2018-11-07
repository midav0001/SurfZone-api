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
    public class ProductController : ApiController
    {

        private readonly IProductService productService;
        private readonly IMapper mapper;

        public ProductController()
        {
            this.productService = new ProductService();
            var config = new MapperConfiguration(cfg =>
           {
               cfg.CreateMap<ProductDTO, Product>().ReverseMap();
           });
            mapper = config.CreateMapper();
        }



        [HttpPost]
        public IHttpActionResult Create(ProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return BadRequest();
            }
            var product = mapper.Map<ProductDTO, Product>(productDTO);
            productService.Create(product);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            productService.Delete(id);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var product = productService.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            var productDTO = mapper.Map<Product, ProductDTO>(product);
            return Ok(productDTO);
        }

        [HttpPut]
        public IHttpActionResult Update(ProductDTO productDTO)
        {
            if (productDTO == null)
            {
                return BadRequest();
            }
            var product = mapper.Map<ProductDTO, Product>(productDTO);
            productService.Update(product);
            return Ok();
        }
    }
}
