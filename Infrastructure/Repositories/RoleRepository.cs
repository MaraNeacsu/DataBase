using Infrastructure.Context;
using Infrastructure.Entities;

namespace ConsoleApp.Repositories
{
    public class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }
}
