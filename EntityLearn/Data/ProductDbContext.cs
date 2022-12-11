using EntityLearn.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityLearn.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        

        // migration command == add-migration "Comment"
        //Update database command == update-database

    }
}
