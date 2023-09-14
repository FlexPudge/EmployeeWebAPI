using Microsoft.EntityFrameworkCore;
using WebApi.DatabaseContext;
using WebApi.Models;

namespace WebApi.Repositorys
{
    public class EmployeeEFRepository : EFRepository<Employee>, IEmployeeRepository
    {
        public EmployeeEFRepository(InMemoryDbContext context) : base(context)
        {
        }
        public override async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _dbSet.Include(e => e.Addresses).ToListAsync();
        }

        public override async Task<Employee> GetByIdAsync(string id)
        {
            return await _dbSet.Include(e => e.Addresses).FirstOrDefaultAsync(e => e.EmployeeId == id);
        }
    }

}
