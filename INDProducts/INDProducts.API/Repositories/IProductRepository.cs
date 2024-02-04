using INDProducts.API.Models;

namespace INDProducts.API.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();

        Task<Product> GetProductByIdAsync(int id);

        Task<Product> CreateProductAsync(Product region);

        Task<Product> UpdateProductAsync(int id, Product product);

        Task<Product> DeleteProductAsync(int id);
    }
}
