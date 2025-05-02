namespace TheFluffyPetApi.models
{
    public class Variant
    {
        public string VariantId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}