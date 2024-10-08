
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Product
    {
        //Properties
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId {get; set;}
        public string? Name {get; set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price {get; set;}
        public string? Description {get; set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost {get; set;}
        public int Stock {get; set;}
        public List<Image>? Images {get; set;}
        public List<Product_image>? Product_Images {get; set;}
        public List<Color>? Colors {get; set;}
        public List<Product_color>? Product_Colors {get; set;}
        public List<Size>? Sizes {get; set;}
        public List<Product_size>? Product_Sizes {get; set;}
        public List<Material>? Materials {get; set;}
        public List<Product_material>? Product_Materials {get; set;}
        public List<Order>? Orders {get; set;}
        public List<Order_Detail>? Order_Details {get; set;}
        public int ProviderId {get; set;}
        public Provider? Provider {get; set;}
        public int CategoryId {get; set;}
        public Category? Category {get; set;}
        
    }
}