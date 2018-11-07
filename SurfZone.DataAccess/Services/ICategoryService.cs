using System;
using System.Collections.Generic;
using System.Text;
using SurfZone.DataAccess.Models;

namespace SurfZone.DataAccess.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        void Create(Category category);
        void Delete(int categoryId);
        IEnumerable<Product> GetAllProducts(int categoryId);
    }
}
