using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SalesCampaign.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } =String.Empty;
        public string Description { get; set; } =String.Empty;

        [JsonIgnore]
        public virtual Campaign Campaign { get; set; }
        public int CampaignId { get; set; }
    }
}
