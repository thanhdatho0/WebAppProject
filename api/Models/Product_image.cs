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
        public int ImageId {get; set;}
        public int ProductId {get; set;}
        public Image? Image {get; set;}
        public Product? Product {get; set;}
    }
}