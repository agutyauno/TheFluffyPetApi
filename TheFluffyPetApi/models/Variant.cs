using System.ComponentModel.DataAnnotations;

namespace TheFluffyPetApi.models
{
    public class Variant
    {
        [Required]
        public string VariantId { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        
        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }
        
        public bool IsAvailable => StockQuantity > 0;
    }
}