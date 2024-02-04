using INDProducts.API.Data;
using INDProducts.API.Models;
using Microsoft.EntityFrameworkCore;

namespace INDProducts.API.Repositories
{
    public class SQLProductRepository : IProductRepository
    {
        private readonly ProductsDbContext _dbContext;

        public SQLProductRepository(ProductsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Product> CreateProductAsync(Product region)
        {
            await _dbContext.Products.AddAsync(region);
            await _dbContext.SaveChangesAsync();
            return region;
        }

        public async Task<Product> DeleteProductAsync(int id)
        {
            var existingProduct = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (existingProduct == null)
            {
                return null;
            }
            _dbContext.Products.Remove(existingProduct);
            await _dbContext.SaveChangesAsync();
            return existingProduct;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Product> UpdateProductAsync(int id, Product product)
        {
            var existingProduct = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (existingProduct == null)
            {
                return null;
            }
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;

            await _dbContext.SaveChangesAsync();
            return existingProduct;
        }
    }
}
