using Infrastructure.Context;
using Infrastructure.Entities;

namespace ConsoleApp.Repositories
{
    public class CategoryRepository : Repo<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
