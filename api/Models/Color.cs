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
        //Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int colorId;
        private string hexaCode = string.Empty;
        private string name = string.Empty;
        private List<Product_color> products = [];
        
        //Get - Set
        public int ColorId { get => colorId; set => colorId = value; }
        public string HexaCode { get => hexaCode; set => hexaCode = value; }
        public string Name { get => name; set => name = value; }
        public List<Product_color> Products { get => products; set => products = value; }

    }
}