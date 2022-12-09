using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;


namespace SalesCampaign.Models

{
    public class Campaign
    {
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Keywords { get; set; } = string.Empty;
        [Required]
        public decimal BitAmount { get; set; }
        [Required]
        public int CampaignFund { get; set; }
        
        public bool StatusON { get; set; }
        public int RadiusKm { get; set; }

         [JsonIgnore]
        //public virtual List<Town> Town { get; set; } 

        public virtual List<Products> Products { get; set; }





    }
}
