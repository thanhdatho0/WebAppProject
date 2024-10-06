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
        public int ColorId {get; set;}
        public Color? Color {get; set;}
        public int ProductId {get; set;}
        public Product? Product {get; set;}
    }
}