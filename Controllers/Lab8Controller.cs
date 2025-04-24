using LAB_8_WEBAPIMASTER;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAB_8_WEBAPIMASTER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lab8Controller : ControllerBase
    {
        private static readonly List<Product> products = new List<Product>()
        {
         new Product { ID = 1001, Name = "Magic Mouse", Price = 100.20 },
         new Product { ID = 1002, Name = "MacBook Pro", Price = 200.20 },
         new Product { ID = 1003, Name = "MacBook Air", Price = 300.20 },
         new Product { ID = 1004, Name = "MacStudio", Price = 400.20 },
         new Product { ID = 1005, Name = "MacMini", Price = 500.20 },
         new Product { ID = 1006, Name = "IMac", Price = 500.20 },
        };
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return GetProducts();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetAction(int id)
        {
            var x = products.FirstOrDefault(p => p.ID == id);
            if (x == null)
            {
                return NotFound(); //return 404 if not Found
            }
            return Ok(x); // retun 200 with the Product
        }
    }
}

