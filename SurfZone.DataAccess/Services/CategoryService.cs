using System;
using System.Collections.Generic;
using System.Text;
using SurfZone.DataAccess.Models;
using SurfZone.DataAccess;

namespace SurfZone.DataAccess.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly SurfZoneContext dbContext;

        public CategoryService()
        {
            this.dbContext = new SurfZoneContext();
        }

        public void Create(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }

        public void Delete(int categoryId)
        {
            var category = dbContext.Categories.Find(categoryId);
            if (category != null)
            {
                dbContext.Categories.Remove(category);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return dbContext.Categories;
        }

        public IEnumerable<Product> GetAllProducts(int categoryId)
        {
            var category = dbContext.Categories.Find(categoryId);
            return category.Products;
        }
    }
}
