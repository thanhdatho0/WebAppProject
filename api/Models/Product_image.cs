using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace api.Models
{

    public class Product_image
    {
        //Properties
        private int imageId;
        private int productId;
        private Image image = new();
        private Product product = new();
        
        //Get - Set
        public int SizeId { get => imageId; set => imageId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public Image Image { get => image; set => image = value; }        
        public Product Product { get => product; set => product = value; }
        
    }
}