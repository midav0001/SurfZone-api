using System;
using System.Collections.Generic;
using System.Text;
using SurfZone.DataAccess.Models;

namespace SurfZone.DataAccess.Services
{
    public class ProductService : IProductService
    {
        private readonly SurfZoneContext dbContext;

        public ProductService()
        {
            this.dbContext = new SurfZoneContext();
        }

        public void Create(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void Delete(int productId)
        {
            var product = dbContext.Products.Find(productId);
            if (product != null)
            {
                dbContext.Products.Remove(product);
                dbContext.SaveChanges();
            }
        }

        public Product Get(int productId)
        {
            var product = dbContext.Products.Find(productId);
            return product;
        }

        public void Update(Product updatingProduct)
        {
            var product = dbContext.Products.Find(updatingProduct.Id);

            if (product != null)
            {
                product.Name = updatingProduct.Name;
                product.Pictures = updatingProduct.Pictures;
                product.Price = updatingProduct.Price;
                product.Description = updatingProduct.Description;
                product.Details = updatingProduct.Details;
                product.Category = updatingProduct.Category;
                product.CategoryId = updatingProduct.CategoryId;

                dbContext.SaveChanges();
            }
        }
    }
}
