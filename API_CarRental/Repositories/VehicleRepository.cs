using API_CarRental.Context;
using API_CarRental.Models;
using API_CarRental.Repositories.Interfaces;

namespace API_CarRental.Repositories
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(AppDbContext context) : base(context)
        {
        }
    }
}
