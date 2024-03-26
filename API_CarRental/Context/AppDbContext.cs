using API_CarRental.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CarRental.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Reservation>? Reservations { get; set; }
        public DbSet<Sale>? Sales { get; set; }
        public DbSet<SalesPerson>? SalesPersons { get; set; }
        public DbSet<Vehicle>? Vehicles { get; set; }
    }
}
