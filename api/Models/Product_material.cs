using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Product_material
    {
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int MaterialId { get; set; }
        public Material? Material { get; set; }
    }
}