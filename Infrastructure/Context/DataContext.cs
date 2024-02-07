using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class DataContext : DbContext
    {
        // Constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // DbSet properties
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
    }
}
