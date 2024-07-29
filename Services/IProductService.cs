using ASP.NET_Core_HW3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_Core_HW3.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllByKey(string key="");
        Task<List<Product>> GetAllAsync();
        Task<Product> GetById(int id);
        Task AddAsync (Product product);
        Task DeleteAsync (int id);
        Task Edit (Product product);
    }
}
