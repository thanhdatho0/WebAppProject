using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Product_color
    {
        //Properties
        private int colorId;
        private int productId;
        private Color color = new();
        private Product product = new();
        
        //Get - Set
        public int ColorId { get => colorId; set => colorId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public Color Color { get => color; set => color = value; }        
        public Product Product { get => product; set => product = value; }
        

    }
}