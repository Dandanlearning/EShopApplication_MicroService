using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationCore.Entity;

namespace ProductAPI.Infrastructure.Data
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryVariation> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<VariationValue> Variations { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
