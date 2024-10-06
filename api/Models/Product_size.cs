using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace api.Models
{
    public class Product_size
    {
        //Properties
        private int sizeId;
        private Size size = new();
        private int productId;
        private Product product = new();
        
        //Get - Set
        public int SizeId { get => sizeId; set => sizeId = value; }
        public Size Size { get => size; set => size = value; }        
        public int ProductId { get => productId; set => productId = value; }
        public Product Product { get => product; set => product = value; }
    }
}