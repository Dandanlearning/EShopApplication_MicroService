using Microsoft.EntityFrameworkCore;
using ProductAPI.Infrastructure.Data;
using ProductAPI.WebApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Infrastructure.Repository
{
    public class BaseRepositoryAsync<T>: IRepositoryAsync<T> where T : class
    {
        private readonly ProductDbContext _db;
        public BaseRepositoryAsync(ProductDbContext db) { this._db = db; }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public Task<int> InsertAsync(T entity) 
        {
            _db.Set<T>().AddAsync(entity);
            return _db.SaveChangesAsync();
        }
    }
}

