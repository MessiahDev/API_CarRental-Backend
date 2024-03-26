using API_CarRental.Context;
using API_CarRental.Models;
using API_CarRental.Repositories.Interfaces;

namespace API_CarRental.Repositories
{
    public class SalesPersonRepository : Repository<SalesPerson>, ISalesPersonRepository
    {
        public SalesPersonRepository(AppDbContext context) : base(context)
        {
        }
    }
}
