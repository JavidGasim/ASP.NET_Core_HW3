using ASP.NET_Core_HW3.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_HW3.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options){ }

        public DbSet<Product> Products { get; set; }
    }
}
