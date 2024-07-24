using FirstAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> products = new List<Product>()
        {
            new Product{PId=1,Name="Herabal Shampoo",Price=350.50},
            new Product{PId=2,Name="Face Wash",Price=350.50},
            new Product{PId=3,Name="Glow & Shine",Price=650.50},
            new Product{PId=4,Name="Anti Aging Cream",Price=850.50},
            new Product{PId=5,Name="Cold Cream",Price=550.50}
        };
        [HttpGet(Name ="GetProducts")]
        public IEnumerable<Product> Get()
        {
            return products;
        }

    }
}
