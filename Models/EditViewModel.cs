using ASP.NET_Core_HW3.Entities;

namespace ASP.NET_Core_HW3.Models
{
    public class EditViewModel
    {
        public Product Product { get; set; }

        public EditViewModel(Product product)
        {
            Product = product;
        }

        public EditViewModel() { }
    }
}
