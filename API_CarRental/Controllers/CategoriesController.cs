using Microsoft.AspNetCore.Mvc;
using API_CarRental.Models;
using API_CarRental.Repositories.Interfaces;
using API_CarRental.Repositories.IServices;

namespace API_CarRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categorieRepository;
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryRepository categoryRepository, ICategoryService categoryService)
        {
            _categorieRepository = categoryRepository;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            var categories = await _categorieRepository.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("CategoriesAndVehicles")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategoriesAndVehicles()
        {
            var categoriesAndVehicles = await _categoryService.GetCategoriesAndCehiclesAsync();
            return Ok(categoriesAndVehicles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _categorieRepository.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return category;
        }

        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            var createdCategory = await _categorieRepository.AddAsync(category);
            return CreatedAtAction(nameof(GetCategory), new { id = createdCategory.Id }, createdCategory);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest("É diferente");
            }

            await _categorieRepository.UpdateAsync(id, category);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _categorieRepository.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            await _categorieRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
