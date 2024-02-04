using INDProducts.API.Models;
using Microsoft.EntityFrameworkCore;

namespace INDProducts.API.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
