using Microsoft.EntityFrameworkCore;
using SalesCampaign.Models;

namespace SalesCampaign.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Campaign> Campaign { get; set; }

        public DbSet<Emerald> Emerald { get; set; }

        public DbSet<Town> Town { get; set; }

    }
}
