using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Size
    {
        //Properties
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SizeId { get; set; }
        public string? SizeValue { get; set; }
        public List<Product>? Products { get; set; }
        public List<Product_size>? Product_Sizes { get; set; }
    }
}