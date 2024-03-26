using Microsoft.AspNetCore.Mvc;
using API_CarRental.Models;
using API_CarRental.Repositories.Interfaces;

namespace API_CarRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly ISaleRepository _saleRepository;

        public SalesController(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sale>>> GetSales()
        {
            var sales = await _saleRepository.GetAllAsync();
            return Ok(sales);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sale>> GetSale(int id)
        {
            var sale = await _saleRepository.GetByIdAsync(id);
            if (sale == null)
            {
                return NotFound();
            }
            return sale;
        }

        [HttpPost]
        public async Task<ActionResult<Sale>> CreateSale(Sale sale)
        {
            var createdSale = await _saleRepository.AddAsync(sale);
            return CreatedAtAction(nameof(GetSale), new { id = createdSale.Id }, createdSale);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSale(int id, Sale sale)
        {
            if (id != sale.Id)
            {
                return BadRequest();
            }

            await _saleRepository.UpdateAsync(id, sale);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSale(int id)
        {
            var sale = await _saleRepository.GetByIdAsync(id);
            if (sale == null)
            {
                return NotFound();
            }

            await _saleRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
