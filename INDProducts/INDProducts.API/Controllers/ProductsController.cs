using INDProducts.API.Data;
using INDProducts.API.Models;
using INDProducts.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace INDProducts.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productRepository.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet]
        [Route("GetProductById/{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProduct product)
        {
            var insertProduct = new Product
            {
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
            };
            insertProduct = await _productRepository.CreateProductAsync(insertProduct); 
            
            return Ok(insertProduct);
        }

        [HttpPut]
        [Route("UpdateProduct/{id}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] int id, UpdateProduct product)
        {
            var updateProduct = new Product
            {
                Description = product.Description,
                Name = product.Name,
                Price = product.Price,
            };
            updateProduct = await _productRepository.UpdateProductAsync(id, updateProduct);
            if (updateProduct == null)
            {
                return NotFound();
            }

            return Ok(updateProduct);
        }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)  
        {
            var existingProduct = await _productRepository.DeleteProductAsync(id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
