using Microsoft.AspNetCore.Mvc;
using API_CarRental.Models;
using API_CarRental.Repositories.Interfaces;
using API_CarRental.Repositories.IServices;

namespace API_CarRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleRepository vehicleRepository, IVehicleService vehicleService)
        {
            _vehicleRepository = vehicleRepository;
            _vehicleService = vehicleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
        {
            var vehicles = await _vehicleRepository.GetAllAsync();
            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return vehicle;
        }

        [HttpGet("count")]
        public async Task<ActionResult<int>> GetVehicleCount()
        {
            var count = await _vehicleService.GetVehicleCount();
            return Ok(count);
        }

        [HttpPost]
        public async Task<ActionResult<Vehicle>> CreateVehicle(Vehicle vehicle)
        {
            var createdVehicle = await _vehicleRepository.AddAsync(vehicle);
            return CreatedAtAction(nameof(GetVehicle), new { id = createdVehicle.Id }, createdVehicle);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }

            await _vehicleRepository.UpdateAsync(id, vehicle);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _vehicleRepository.GetByIdAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            await _vehicleRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
