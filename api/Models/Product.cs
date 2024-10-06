using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Product
    {
        //Properties
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int productId;
        private string name = string.Empty;
        private decimal price;
        [Column(TypeName = "decimal(18,2)")]
        private string description = string.Empty;
        private decimal cost;
        [Column(TypeName = "decimal(18,2)")]
        private int stock;
        private List<Product_image> images = [];
        private List<Product_color> colors = [];
        private List<Product_size> sizes = [];
        private List<Product_material> materials = [];
        private int categoryId;
        private Category category = new();

        //Get - Set
        public int ProductId { get => productId; set => productId = value; }
        public string Name { get => name; set => name = value; }       
        public decimal Price { get => price; set => price = value; }
        public decimal Crice { get => cost; set => cost = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Description { get => description; set => description = value; }
        public List<Product_image> Images { get => images; set => images = value; }
        public List<Product_color> Colors { get => colors; set => colors = value; }
        public List<Product_size> Sizes { get => sizes; set => sizes = value; }
        public List<Product_material> Materials { get => materials; set => materials = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public Category Category { get => category; set => category = value; }
        
    }
}