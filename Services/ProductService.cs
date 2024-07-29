using ASP.NET_Core_HW3.Entities;
using ASP.NET_Core_HW3.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_Core_HW3.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<List<Product>> GetAllByKey(string key = "")
        {
            return await _productRepository.GetAllByKeyAsync(key);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task Edit(Product product)
        {
            await _productRepository.EditAsync(product);
        }

        public async Task<Product> GetById(int id)
        {
            return await _productRepository.GetById(id);
        }
    }
}
