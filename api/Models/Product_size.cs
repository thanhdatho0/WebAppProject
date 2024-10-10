
namespace api.Models
{
    public class Product_size
    {
        public int SizeId { get; set; }
        public Size? Size { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}