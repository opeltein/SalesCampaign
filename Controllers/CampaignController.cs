using Microsoft.AspNetCore.Mvc;
using SalesCampaign.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesCampaign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private static List<Campaign> campaigns = new List<Campaign>{};

        private readonly DataContext _context;

        public CampaignController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<CampaignController>
        [HttpGet]
        public async Task<ActionResult<List<Campaign>>> GetCampaigns(int id)
        {
            var campaign = await _context.Campaign.FindAsync(id);
            if (campaign == null) return NotFound();

            return Ok(await _context.Campaign.ToListAsync());
        }

        // GET api/<CampaignController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Campaign>>> GetCampaign(int id)
        {
            var campaign = await _context.Campaign.FindAsync(id);
            if (campaign == null) return NotFound();
            return Ok(campaign);
        }

        // POST api/<CampaignController>
        [HttpPost]
        public async Task<ActionResult<List<Campaign>>> Post(Campaign campaign)
        {
            _context.Campaign.Add(campaign);
            await _context.SaveChangesAsync();

            return Ok(await _context.Campaign.ToListAsync());
        }

        // PUT api/<CampaignController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Campaign>>> PutCampaign(Campaign request)
        {
            var dbCampaign = await _context.Campaign.FindAsync(request.Id);
            if (dbCampaign == null) return NotFound();

            dbCampaign.Name = request.Name;
            dbCampaign.Keywords = request.Keywords;
            dbCampaign.BitAmount = request.BitAmount;
            dbCampaign.CampaignFund = request.CampaignFund;
            dbCampaign.StatusON = request.StatusON;
            dbCampaign.RadiusKm = request.RadiusKm;
            dbCampaign.Products = request.Products;

            await _context.SaveChangesAsync();
            return Ok(await _context.Campaign.ToListAsync());

        }

        // DELETE api/<CampaignController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Campaign>>> DeleteCampaig(int id)
        {
            var dbCampaig = await _context.Campaign.FindAsync(id);
            if (dbCampaig == null) return NotFound();


            _context.Campaign.Remove(dbCampaig);
            await _context.SaveChangesAsync();
            return Ok(await _context.Campaign.ToListAsync());

        }
    }
}
