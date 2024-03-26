using API_CarRental.Context;
using API_CarRental.Models;
using API_CarRental.Repositories.Interfaces;
using API_CarRental.Repositories.IServices;
using Microsoft.EntityFrameworkCore;

namespace API_CarRental.Repositories.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<int> GetVehicleCount()
        {
            var vehicles = await _vehicleRepository.GetAllAsync();
            return vehicles.Count();
        }
    }
}
