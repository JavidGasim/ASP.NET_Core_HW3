using ASP.NET_Core_HW3.Entities;

namespace ASP.NET_Core_HW3.Models
{
    public class AddViewModel
    {
        public Product Product { get; set; }
        public AddViewModel() { }
        public AddViewModel(Product product)
        {
            this.Product = product;
        }
    }
}
