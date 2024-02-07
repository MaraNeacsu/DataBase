using Infrastructure.Context;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ConsoleApp.Repositories
{
    public class CustomerRepository : Repo<CustomerEntity>
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override CustomerEntity Create(CustomerEntity entity)
        {
            return base.Create(entity);
        }

        public override void Delete(Expression<Func<CustomerEntity, bool>> expression)
        {
            base.Delete(expression);
        }

        public override CustomerEntity Get(Expression<Func<CustomerEntity, bool>> expression)
        {
            var entity = _context.Customers
                .Include(i => i.Address)
                .Include(i => i.Role)
                .FirstOrDefault(expression);

            return entity!;
        }

        public override IEnumerable<CustomerEntity> GetAll()
        {
            return _context.Customers
                .Include(i => i.Address)
                .Include(i => i.Role)
                .ToList();
        }

        public override CustomerEntity Update(Expression<Func<CustomerEntity, bool>> expression, CustomerEntity entity)
        {
            return base.Update(expression, entity);
        }
    }
}
