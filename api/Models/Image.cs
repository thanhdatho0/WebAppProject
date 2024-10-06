using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Image
    {
        //Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId {get; set;}
        public string? Url {get; set;}
        public string? Alt {get; set;}
        public List<Product>? Products { get; set; }
        public List<Product_image>? Product_Imagescts {get; set;}
    }
}