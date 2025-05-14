using System.ComponentModel.DataAnnotations;

namespace TheFluffyPetApi.models
{
    public class Product
    {
        [Required]
        public string ProductId { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public string Brand {get; set;} = string.Empty;
        
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        
        public List<string> ImageUrl { get; set; } = [];
        
        [Range(0, 100)]
        public float Discount { get; set; }
        
        [Required]
        public string Category {get; set;} = string.Empty;
        
        public List<Variant> Variants {get; set;} = [];
    }
}