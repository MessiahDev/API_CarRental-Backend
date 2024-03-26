using API_CarRental.Context;
using API_CarRental.Models;
using API_CarRental.Repositories.Interfaces;

namespace API_CarRental.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
