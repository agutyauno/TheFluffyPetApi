using Microsoft.AspNetCore.Mvc;
using TheFluffyPetApi.models;

namespace TheFluffyPetApi.controllers
{
    [ApiController]
    [Route("api/Products")]
    public class ProductsControllers : ControllerBase
    {
        static readonly List<Product> products = [];

        public ProductsControllers()
        {
            AddProduct(new Product
            {
                ProductId = "p001",
                Name = "Cat Food",
                Brand = "ncc",
                Description = "High-quality cat food.",
                ImageUrl = [ 
                    "https://paddy.vn/cdn/shop/files/do-choi-meo-cattyman-thu-bong-luoi.png?v=1694500545",
                    "https://cdn.shopify.com/s/files/1/0624/1746/9697/files/12355_800x_d3c0cba8-31d1-47f3-a284-7d81d2ad6e0f_600x600.webp?v=1671510632",
                    "https://cdn.chiaki.vn/unsafe/0x960/left/top/smart/filters:quality(70)/https://chiaki.vn/upload/news/content/2021/01/thuc-an-cho-meo-me-o-kitten-ocean-fish-jpg-1609987233-07012021094033.jpg",
                    "https://www.phukienthucungdep.com/upload/product/normal/thuc-an-cho-meo-con1.jpg",
                    "https://haitau.vn/wp-content/uploads/2023/06/image3-min-5.jpg"
                ],
                Discount = 0,
                Category = "food",
                Variants = [
                    new Variant
                    {
                        VariantId = "p001v01",
                        Name = "Small",
                        Price = 99000,
                        StockQuantity = 100
                    },
                    new Variant
                    {
                        VariantId = "p001v02",
                        Name = "Large",
                        Price = 66000,
                        StockQuantity = 50
                    }
                ]
            });
            AddProduct(new Product
            {
                ProductId = "p002",
                Name = "dog Food",
                Brand = "ncct",
                Description = "High-quality dog food.",
                ImageUrl = [ 
                    "https://paddy.vn/cdn/shop/files/do-choi-meo-cattyman-thu-bong-luoi.png?v=1694500545",
                    "https://cdn.shopify.com/s/files/1/0624/1746/9697/files/12355_800x_d3c0cba8-31d1-47f3-a284-7d81d2ad6e0f_600x600.webp?v=1671510632",
                    "https://cdn.chiaki.vn/unsafe/0x960/left/top/smart/filters:quality(70)/https://chiaki.vn/upload/news/content/2021/01/thuc-an-cho-meo-me-o-kitten-ocean-fish-jpg-1609987233-07012021094033.jpg",
                    "https://www.phukienthucungdep.com/upload/product/normal/thuc-an-cho-meo-con1.jpg",
                    "https://haitau.vn/wp-content/uploads/2023/06/image3-min-5.jpg"
                ],
                Discount = 0,
                Category = "food",
                Variants = [
                    new Variant
                    {
                        VariantId = "p002v01",
                        Name = "Small",
                        Price = 100000,
                        StockQuantity = 100
                    },
                    new Variant
                    {
                        VariantId = "p002v02",
                        Name = "Large",
                        Price = 150000,
                        StockQuantity = 50
                    }
                ]
            });
        }

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