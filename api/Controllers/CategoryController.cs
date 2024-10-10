using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.DTOs;
using api.DTOs.Category;
using api.Interfaces;
using api.Mappers;
using api.Models;
using api.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ICategoryRepository _categoryRepo;

        public CategoryController(ApplicationDbContext context, ICategoryRepository categoryRepo){
            _context = context;
            _categoryRepo = categoryRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            var categories =  await _categoryRepo.GetAllAsync();
            var categoryDTO = categories.Select(s => s.toCategoryDTO());
            return Ok(categoryDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id){
            var category = await _categoryRepo.GetByIdAsync(id);
            if(category == null)
                return NotFound();
            return Ok(category.toCategoryDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryCreateDTO categoryDTO){
            var category = categoryDTO.toCategoryFromCreateDTO();
            await _categoryRepo.CreateAsync(category);
            return CreatedAtAction(nameof(GetById), new {id = category.CategoryId}, category.toCategoryDTO());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] CategoryUpdateDTO categoryDTO){
            var category = await _categoryRepo.UpdateAsync(id, categoryDTO);
            return Ok(category?.toCategoryDTO());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id){
            var category = await _categoryRepo.DeleteAsync(id);
            if(category == null) return NotFound();
            return NoContent();
        }
        
    }
}