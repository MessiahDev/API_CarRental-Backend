using Microsoft.AspNetCore.Mvc;
using API_CarRental.Models;
using API_CarRental.Repositories.Interfaces;

namespace API_CarRental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesPersonsController : ControllerBase
    {
        private readonly ISalesPersonRepository _salesPersonRepository;

        public SalesPersonsController(ISalesPersonRepository salesPersonRepository)
        {
            _salesPersonRepository = salesPersonRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesPerson>>> GetSalesPersons()
        {
            var salesPersons = await _salesPersonRepository.GetAllAsync();
            return Ok(salesPersons);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalesPerson>> GetSalesPerson(int id)
        {
            var salesPerson = await _salesPersonRepository.GetByIdAsync(id);
            if (salesPerson == null)
            {
                return NotFound();
            }
            return salesPerson;
        }

        [HttpPost]
        public async Task<ActionResult<SalesPerson>> CreateSalesPerson(SalesPerson salesPerson)
        {
            var createdSalesPerson = await _salesPersonRepository.AddAsync(salesPerson);
            return CreatedAtAction(nameof(GetSalesPerson), new { id = createdSalesPerson.Id }, createdSalesPerson);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSalesPerson(int id, SalesPerson salesPerson)
        {
            if (id != salesPerson.Id)
            {
                return BadRequest();
            }

            await _salesPersonRepository.UpdateAsync(id, salesPerson);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesPerson(int id)
        {
            var salesPerson = await _salesPersonRepository.GetByIdAsync(id);
            if (salesPerson == null)
            {
                return NotFound();
            }

            await _salesPersonRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
