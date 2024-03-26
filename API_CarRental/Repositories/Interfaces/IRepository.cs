using API_CarRental.Models;

namespace API_CarRental.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(int id, TEntity entity);
        Task<bool> DeleteAsync(int id);
    }
}
