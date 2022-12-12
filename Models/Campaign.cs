using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;


namespace SalesCampaign.Models

{
    public class Campaign
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        //Typeahead musiał by zostać zaimplementowany w view model(nie dotyczy w tym wypadku)
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


        //Aplikacja wymaga przy POST dodania listy 


    }
}
