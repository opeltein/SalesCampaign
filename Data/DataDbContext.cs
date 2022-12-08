using Microsoft.EntityFrameworkCore;
using SalesCampaign.Models;

namespace SalesCampaign.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Products> AllProducts { get; set; }
    }
}
