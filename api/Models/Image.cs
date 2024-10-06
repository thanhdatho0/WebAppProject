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
        private int imageId;
        private string url = string.Empty;
        private string alt = string.Empty;
        private List<Product_image> products = [];

        //Get - Set
        public int ImageId { get => imageId; set => imageId = value; }
        public string Url { get => url; set=> url = value; }
        public string Alt { get => alt; set=> alt = value; }
        public List<Product_image> Products { get => products; set => products = value; }
    }
}