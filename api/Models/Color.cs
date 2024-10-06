using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Color
    {
        [Key]
        //Properties
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColorId { get; set; }
        public string? HexaCode { get; set; }
        public string? Name { get; set; }
        public List<Product>? Products { get; set; }
        public List<Product_color>? Product_Colors { get; set; }
    }
}