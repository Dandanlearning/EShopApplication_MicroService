using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.WebApplicationCore.Interfaces
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<int> InsertAsync(T entity);
        Task<IEnumerable<T>> GetAll();
    }
}
