
namespace api.Models
{
    public class Order_Detail
    {
        public int OrderId {get; set;}
        public Order? Order {get; set;}
        public int ProductId {get; set;}
        public Product? Product {get; set;}
        public int Amount {get; set;}
    }
}