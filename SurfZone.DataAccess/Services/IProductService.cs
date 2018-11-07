using System;
using System.Collections.Generic;
using System.Text;
using SurfZone.DataAccess.Models;


namespace SurfZone.DataAccess.Services
{
    public interface IProductService
    {
        Product Get(int productId);
        void Create(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
