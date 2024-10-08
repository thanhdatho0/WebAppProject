
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Material
    {
        //Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialId { get; set; }
        public string? MaterialType { get; set; }
        public List<Product>? Products { get; set; }
        public List<Product_material>? Product_Materials { get; set; }
    }
}