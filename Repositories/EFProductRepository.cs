using ASP.NET_Core_HW3.Data;
using ASP.NET_Core_HW3.Entities;
using ASP.NET_Core_HW3.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_HW3.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public EFProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = _context.Products.Where(p => p.Id == id).SingleOrDefault();

            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllByKeyAsync(string key)
        {
            var keyCode = key.ToLower();
            return await _context.Products.Where(p => p.Name.ToLower().Contains(keyCode)).ToListAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            var result = _context.Products.Where(p => p.Id == id).SingleOrDefault();
            return result;
        }
    }
}
