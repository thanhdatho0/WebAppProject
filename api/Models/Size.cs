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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int sizeId;
        private string sizeValue = string.Empty;
        private List<Product_size> products = [];

        //Get - Set
        public int SizeId { get => sizeId; set => sizeId = value; }
        public string SizeValue { get => sizeValue; set => sizeValue = value; }
        public List<Product_size> Products { get => products; set => products = value; }
    }
}