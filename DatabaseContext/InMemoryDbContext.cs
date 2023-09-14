using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.DatabaseContext
{
    public class InMemoryDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "EmployeeDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
              .HasIndex(e => new { e.FirstName, e.LastName, e.EmailAddress })
              .IsUnique(true);
        }
    }
}
