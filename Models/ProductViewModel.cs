using ASP.NET_Core_HW3.Entities;
using System.Collections.Generic;

namespace ASP.NET_Core_HW3.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public ProductViewModel()
        {
        }
    }
}
