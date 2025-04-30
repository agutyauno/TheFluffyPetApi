using Microsoft.AspNetCore.Mvc;
using TheFluffyPetApi.models;

namespace TheFluffyPetApi.controllers
{
    [ApiController]
    [Route("api/Products")]
    public class ProductsControllers : ControllerBase
    {
        static readonly List<Product> products = [];

        [HttpGet]
        public IActionResult GetAllProducts([FromQuery] int? limit)
        {
            if (limit.HasValue && limit.Value > 0)
            {
                return Ok(products.Take(limit.Value));
            }
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(string id)
        {
            Product? product = products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound($"Product with id {id} not found.");
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (products.Any(p => p.ProductId == product.ProductId))
            {
                return Conflict($"Product with id {product.ProductId} already exists.");
            }

            products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
        }
    }
}