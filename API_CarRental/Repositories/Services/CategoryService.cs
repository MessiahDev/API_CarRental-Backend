using API_CarRental.Context;
using API_CarRental.Models;
using API_CarRental.Repositories.Interfaces;
using API_CarRental.Repositories.IServices;
using Microsoft.EntityFrameworkCore;

namespace API_CarRental.Repositories.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAndCehiclesAsync()
        {
            return await _context.Categories.Include(c => c.Vehicles).ToListAsync();
        }
    }
}
