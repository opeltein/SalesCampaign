﻿using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace SalesCampaign.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; } =String.Empty;
        public string Description { get; set; } =String.Empty;

        [JsonIgnore]
        public virtual List<Campaign> Campaign { get; set; }
    }
}
