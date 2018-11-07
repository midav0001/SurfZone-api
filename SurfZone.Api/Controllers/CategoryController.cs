using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SurfZone.Api.DTO;
using SurfZone.DataAccess;
using SurfZone.DataAccess.Services;
using SurfZone.DataAccess.Models;
using AutoMapper;

namespace SurfZone.Api.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryService categoryService;
        
        private readonly IMapper mapper;

        public CategoryController()
        {
            this.categoryService = new CategoryService();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryDTO>().ReverseMap();
                cfg.CreateMap<Product, ProductDTO>().ReverseMap();
            });
            mapper = config.CreateMapper();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var categories = categoryService.GetAll();
            var categoriesDTO = categories.Select(p => mapper.Map<Category, CategoryDTO>(p));
            return Ok(categoriesDTO);
        }

        [HttpPost]
        public IHttpActionResult Create(CategoryDTO categoryDTO)
        {
            if (categoryDTO == null)
            {
                return BadRequest();
            }
            var category = mapper.Map<CategoryDTO, Category>(categoryDTO);
            categoryService.Create(category);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            categoryService.Delete(id);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetAllProduct(int id)
        {
            var products = categoryService.GetAllProducts(id);
            if (products == null)
            {
                return NotFound();
            }
            var productsDTO = products.Select(p => mapper.Map<Product, ProductDTO>(p));
            return Ok(productsDTO);
        }
    }
}
