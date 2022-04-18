using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiWithdotNetSix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
                new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
                new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
            };

            return Ok(products);

        }
                
           
        
    }
}
