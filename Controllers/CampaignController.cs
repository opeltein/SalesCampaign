using Microsoft.AspNetCore.Mvc;
using SalesCampaign.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesCampaign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private static List<Campaign> campaigns = new List<Campaign>
            {
                new Campaign {
                    Id = 1,
                    Name = "Christmas price cut in Poland",
                    Keywords = "Christmas",
                    BitAmount = 12.218m,
                    CampaignFund = 25 ,
                    StatusON = true ,
                    RadiusKm = 100 ,

                },

                new Campaign {
                    Id = 2,
                    Name = "Christmas price cut for all",
                    Keywords = "Christmas,forAll,",
                    BitAmount = 166.218m,
                    CampaignFund = 105 ,
                    StatusON = false ,
                    RadiusKm = 1000 ,

                }

            };

        // GET: api/<CampaignController>
        [HttpGet]
        public async Task<ActionResult<List<Campaign>>> GetCampaigns(int page = 0, int pageSize = 10)
        {
            return Ok(campaigns);
        }

        // GET api/<CampaignController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Campaign>>> GetCampaign(int id)
        {
            var campaign = campaigns.Find(c => c.Id == id);
            if (campaign == null) return NotFound();
            return Ok(campaigns);
        }

        // POST api/<CampaignController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CampaignController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CampaignController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
