using ProductAPI.Infrastructure.Data;
using ProductAPI.WebApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationCore.Entity;

namespace ProductAPI.Infrastructure.Repository
{
    public class ProductRepositoryAsync : BaseRepositoryAsync<Product>, IProductRepositoryAsync
    {
        public ProductRepositoryAsync(ProductDbContext db) : base(db)
        {
        }
    }
}
