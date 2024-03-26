using API_CarRental.Models;

namespace API_CarRental.Repositories.IServices
{
    public interface IVehicleService
    {
        Task<int> GetVehicleCount();
    }
}
