namespace TheFluffyPetApi.models
{
    public class Product
    {
        public string ProductId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Brand {get; set;} = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> ImageUrl { get; set; } = [];
        public float Discount { get; set; }
        public string Category {get; set;} = string.Empty;
        public List<Variant> Variants {get; set;} = [];
    }
}