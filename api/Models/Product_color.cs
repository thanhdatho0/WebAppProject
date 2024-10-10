
namespace api.Models
{
    public class Product_color
    {
        //Properties
        public int ColorId {get; set;}
        public Color? Color {get; set;}
        public int ProductId {get; set;}
        public Product? Product {get; set;}
    }
}