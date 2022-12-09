﻿using Microsoft.EntityFrameworkCore;
using SalesCampaign.Models;

namespace SalesCampaign.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }

    }
}
