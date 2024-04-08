using API_CarRental.Models;

namespace API_CarRental.Repositories.IServices
{
    public interface IReservationService
    {
        Task<IEnumerable<Reservation>> GetReservationsAndCategories();
    }
}
