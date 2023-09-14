using WebApi.DatabaseContext;
using WebApi.Models;

namespace WebApi.Repositorys
{
    public class AddressEFRepository : EFRepository<Address>, IAddressRepository
    {
        public AddressEFRepository(InMemoryDbContext context) : base(context)
        {
        }
    }
}
