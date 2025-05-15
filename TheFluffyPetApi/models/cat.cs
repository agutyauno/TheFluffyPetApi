namespace TheFluffyPetApi.Models
{
    public class Cat
    {
        public string CatId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string Color { get; set; } = string.Empty;
        public DateOnly BirthDate { get; set; }
        public float Weight { get; set; }
        public string HealthStatus { get; set; } = string.Empty;
        public bool IsDeworming { get; set; }
        public List<DateOnly> VaccinateDates { get; set; } = [];
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<string> ImageUrls { get; set; } = new List<string>();
        public float Discount { get; set; }
    }
}