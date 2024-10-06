using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Material
    {
        //Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int materialId;
        private string materialType = string.Empty;
        private List<Product_material> products = [];

        public int MaterialId { get => materialId; set => materialId = value; }
        public string MaterialType { get => materialType; set => materialType = value; }
        public List<Product_material> Products { get => products; set => products = value; }
    }
}