using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs;
using api.DTOs.Category;
using api.Models;

namespace api.Mappers
{
    public static class CategoryMappers
    {
        public static CategoryDTO toCategoryDTO(this Category categoryModel){
            return new CategoryDTO{
                Name = categoryModel.Name,
                Description = categoryModel.Description
            };
        }

        public static Category toCategoryFromCreateDTO(this CategoryCreateDTO categoryDTO){
            return new Category{
                Name = categoryDTO.Name,
                Description = categoryDTO.Description
            };
        }

        public static Category toCategoryFromUpdateDTO(this CategoryUpdateDTO categoryDTO){
            return new Category{
                Name = categoryDTO.Name,
                Description = categoryDTO.Description
            };
        }
    }
}