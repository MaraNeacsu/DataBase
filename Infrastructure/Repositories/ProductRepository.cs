using Infrastructure.Context;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ConsoleApp.Repositories
{
    public class ProductRepository : Repo<ProductEntity>
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override ProductEntity Create(ProductEntity entity)
        {
            return base.Create(entity);
        }

        public override void Delete(Expression<Func<ProductEntity, bool>> expression)
        {
            base.Delete(expression);
        }

        public override ProductEntity Get(Expression<Func<ProductEntity, bool>> expression)
        {
            var entity = _context.Products
                .Include(i => i.Category)
                .FirstOrDefault(expression);

            return entity!;
        }

        public override IEnumerable<ProductEntity> GetAll()
        {
            return _context.Products
                .Include(i => i.Category)
                .ToList();
        }

        public override ProductEntity Update(Expression<Func<ProductEntity, bool>> expression, ProductEntity entity)
        {
            return base.Update(expression, entity);
        }
    }
}
