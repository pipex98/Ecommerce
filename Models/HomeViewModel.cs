using ecommerce.Common;
using ecommerce.Data.Entities;

namespace ecommerce.Models
{
    public class HomeViewModel
    {
        public PaginatedList<Product> Products { get; set; }
        public float Quantity { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
