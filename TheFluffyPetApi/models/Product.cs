namespace TheFluffyPetApi.models
{
    public class Product
    {
        public string ProductId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Brand {get; set;} = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public string Category {get; set;} = string.Empty;
        public int stockQuantity { get; set; }
    }
}