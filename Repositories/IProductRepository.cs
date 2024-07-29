using ASP.NET_Core_HW3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_Core_HW3.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<List<Product>> GetAllByKeyAsync(string key);
        Task<Product> GetById(int id);
        Task AddAsync(Product product);
        Task DeleteAsync(int id);
        Task EditAsync(Product product);
    }
}
