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
        static readonly List<Dog> dogs = new List<Dog>();

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