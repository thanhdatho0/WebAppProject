using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Product_material
    {
        private int productId;
        private int materialId;
        private Product product = new();
        private Material material = new();

        public int ProductId { get => productId; set => productId = value; }
        public int MaterialId { get => materialId; set => materialId = value; }
        public Product Product { get => product; set => product = value; }
        public Material Material { get => material; set => material = value; }
    }
}