using Infrastructure.Context;
using Infrastructure.Entities;

namespace ConsoleApp.Repositories
{
    public class AddressRepository : Repo<AddressEntity>
    {
        public AddressRepository(DataContext context) : base(context)
        {
        }
    }
}
