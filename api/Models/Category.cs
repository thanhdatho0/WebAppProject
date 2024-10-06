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
        [Key]
        //Properties
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId {get; set;}
        public string? Name {get; set;}
        public string? Description {get; set;}
        public List<Product>? Products {get; set;}
    }
}