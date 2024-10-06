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
        public int SizeId { get; set; }
        public Size? Size { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}