using API_CarRental.Context;
using API_CarRental.Models;
using API_CarRental.Repositories.IServices;
using Microsoft.EntityFrameworkCore;

namespace API_CarRental.Repositories.Services
{
    public class ReservationService : IReservationService
    {
        private readonly AppDbContext _context;

        public ReservationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reservation>> GetReservationsAndCategories()
        {
            return await _context.Reservations
                        .Include(r => r.Category)
                        .ThenInclude(r => r.Vehicles)
                        .ToListAsync();
        }
    }
}
