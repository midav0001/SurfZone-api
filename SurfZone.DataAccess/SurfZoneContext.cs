using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using SurfZone.DataAccess.Models;

namespace SurfZone.DataAccess
{


    public class SurfZoneContext : DbContext
    {
        private const string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SurfZone;Persist Security Info=True;User ID=sa;Password=123456;Pooling=False";

        public SurfZoneContext()
            : base(ConnectionString)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
