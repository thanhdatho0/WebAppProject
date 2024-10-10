using System.ComponentModel.DataAnnotations;

namespace api.DTOs.Category
{
    public class CategoryCreateDTO
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}