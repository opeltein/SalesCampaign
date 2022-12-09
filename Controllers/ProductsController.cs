using Microsoft.AspNetCore.Mvc;
using SalesCampaign.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesCampaign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Products> products = new List<Products>
            {
                new Products {
                    Id = 1,
                    Name = "Smartwatch" ,
                    Description = "A smartwatch is a wearable computer in the form of a watch;" +
                    " modern smartwatches provide a local touchscreen interface for daily use, " +
                    "while an associated smartphone app provides for management and telemetry, " +
                    "such as long-term biomonitoring",
                },
                new Products {
                    Id = 2,
                    Name = "Smartphone" ,
                    Description = "A smartphone is a portable computer device that combines mobile" +
                    " telephone and computing functions into one unit. They are distinguished from" +
                    " feature phones by their stronger hardware capabilities and extensive mobile operating systems," +
                    " which facilitate wider software, internet, etc.",
                }
            };



        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetProducts(int page = 0, int pageSize = 10)
        {
                            
            return Ok(products);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Products>>> GetProduct(int id)
        {
            var product = products.Find(p => p.Id == id);
            if(product == null) return NotFound();
            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult<List<Products>>> Post(Products product)
        {
            products.Add(product);
            return Ok(products);
        }

        
    }
}
