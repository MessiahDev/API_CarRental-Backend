using API_CarRental.Models;

namespace API_CarRental.Repositories.IServices
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategoriesAndCehiclesAsync();
    }
}
