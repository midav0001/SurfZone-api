using SurfZone.DataAccess.Models;
using System.Collections.Generic;

namespace SurfZone.Api.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}