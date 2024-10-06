using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Category
    {
        //Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int categoryIdid;
        private string name = string.Empty;
        private string description = string.Empty;
        private List<Product> products = [];

        //Get - Set
        public int CategoryIdid { get => categoryIdid; set => categoryIdid = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public List<Product> Products { get => products; set => products = value; }
    }
}