using Microsoft.AspNetCore.Mvc;
using SalesCampaign.Models;



namespace SalesCampaign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Products> products = new List<Products>{};

        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetAllProducts(int page = 0, int pageSize = 10)
        {
                            
            return Ok(await _context.Products.ToListAsync());
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Products>>> GetProducts(int id)
        {
            var product = products.Find(p => p.Id == id);
            if(product == null) return NotFound();
            return Ok(product);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult<List<Products>>> PostProducts(Products product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();  

            return Ok(await _context.Products.ToListAsync());
        }

        [HttpPut]

        public async Task<ActionResult<List<Products>>> PutProducts(Products request)
        {
            var dbProduct = await _context.Products.FindAsync(request.Id);
            if (dbProduct == null) return NotFound();

            dbProduct.Name = request.Name;
            dbProduct.Description = request.Description;
            dbProduct.CampaignId = request.CampaignId;

            await _context.SaveChangesAsync();
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Products>>> DeleteProducts(int id)
        {
            var dbProduct = await _context.Products.FindAsync(id);
            if (dbProduct == null) return NotFound();
            

            _context.Products.Remove(dbProduct);
            await _context.SaveChangesAsync();
            return Ok(await _context.Products.ToListAsync());

        }

    }
}
