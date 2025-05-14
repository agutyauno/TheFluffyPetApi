using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheFluffyPetApi.Models;

namespace TheFluffyPetApi.controllers
{
    [ApiController]
    [Route("api/dogs")]
    public class DogsController : ControllerBase
    {
        static readonly List<Dog> dogs = [];

        public DogsController()
        {
            AddDog(new Dog
            {
                DogId = "d001",
                Name = "Lucky",
                Breed = "Golden Retriever",
                Gender = true,
                Age = 2,
                Color = "Golden",
                BirthDate = new DateOnly(2022, 5, 15),
                Weight = 32.5f,
                HealthStatus = "Excellent",
                IsDeworming = true,
                VaccinateDates =
                [
                    new DateOnly(2022, 6, 15),
                    new DateOnly(2022, 9, 15),
                    new DateOnly(2023, 3, 15)
                ],
                Price = 15000000,
                Description = "Friendly and well-trained Golden Retriever",
                ImageUrl = "https://cdn.pixabay.com/photo/2019/07/30/05/53/dog-4372036_1280.jpg",
                Discount = 0
            });

            AddDog(new Dog
            {
                DogId = "d002",
                Name = "Bella",
                Breed = "Husky",
                Gender = false,
                Age = 1,
                Color = "White and Grey",
                BirthDate = new DateOnly(2023, 1, 10),
                Weight = 25.0f,
                HealthStatus = "Good",
                IsDeworming = true,
                VaccinateDates =
                [
                    new DateOnly(2023, 2, 10),
                    new DateOnly(2023, 5, 10),
                    new DateOnly(2023, 8, 10)
                ],
                Price = 12000000,
                Description = "Energetic and playful Siberian Husky",
                ImageUrl = "https://cdn.pixabay.com/photo/2018/05/07/10/48/husky-3380548_1280.jpg",
                Discount = 5.0f
            });

            AddDog(new Dog
            {
                DogId = "d003",
                Name = "Max",
                Breed = "Corgi",
                Gender = true,
                Age = 1,
                Color = "Brown and White",
                BirthDate = new DateOnly(2023, 3, 20),
                Weight = 12.0f,
                HealthStatus = "Excellent",
                IsDeworming = true,
                VaccinateDates =
                [
                    new DateOnly(2023, 4, 20),
                    new DateOnly(2023, 7, 20)
                ],
                Price = 20000000,
                Description = "Adorable and smart Pembroke Welsh Corgi",
                ImageUrl = "https://cdn.pixabay.com/photo/2019/08/19/07/45/corgi-4415649_1280.jpg",
                Discount = 10.0f
            });
        }

        [HttpGet]
         public IActionResult GetAllCats([FromQuery] int? limit)
        {
             if (limit.HasValue && limit.Value > 0)
            {
                return Ok(dogs.Take(limit.Value));
            }
            return Ok(dogs);
        }

        [HttpGet("{id}")]
        public IActionResult GetDog(string id)
        {
            Dog? dog = dogs.FirstOrDefault(d => d.DogId == id);
            if (dog == null)
            {
                return NotFound($"Dog with id {id} not found.");
            }
            return Ok(dog);
        }

        [HttpPost]
        public IActionResult AddDog(Dog dog)
        {
            if (dogs.Any(d => d.DogId == dog.DogId))
            {
                return Conflict($"Dog with id {dog.DogId} already exists.");
            }

            dogs.Add(dog);
            return CreatedAtAction(nameof(GetDog), new { id = dog.DogId }, dog);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDog(string id, Dog updatedDog)
        {
            Dog? existingDog = dogs.FirstOrDefault(d => d.DogId == id);
            if (existingDog == null)
            {
                return NotFound($"Dog with id {id} not found.");
            }

            existingDog.Name = updatedDog.Name;
            existingDog.Breed = updatedDog.Breed;
            existingDog.Price = updatedDog.Price;
            existingDog.Description = updatedDog.Description;
            existingDog.ImageUrl = updatedDog.ImageUrl;
            return NoContent();
        }
    }
}