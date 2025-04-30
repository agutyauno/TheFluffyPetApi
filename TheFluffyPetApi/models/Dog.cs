namespace TheFluffyPetApi.Models
{
    public class Dog
    {
        public string DogId { get; set; } = string.Empty;
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
        public string ImageUrl { get; set; } = string.Empty;
        public float Discount { get; set; }
    }
}