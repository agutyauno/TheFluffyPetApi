using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TheFluffyPetApi.Models;

namespace TheFluffyPetApi.controllers
{
    [ApiController]
    [Route("api/cats")]
    public class CatsController : ControllerBase
    {
        static readonly List<Cat> cats =[];

        public CatsController()
        {
            AddCat(new Cat
            {
                CatId = "c001",
                Name = "Mimi",
                Breed = "anh lông ngắn",
                Gender = true,
                Age = 2,
                Color = "xám khói",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = new List<DateOnly> { new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1) },
                Price = 5000000,
                Description = "A fluffy stupid cat.",
                ImageUrl = "https://thepet.vn/wp-content/uploads/2024/12/meo-anh-long-ngan-9.jpg",
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c002",
                Name = "Mao mao",
                Breed = "xiêm",
                Gender = true,
                Age = 1,
                Color = "trắng",
                BirthDate = new DateOnly(2024, 6, 1),
                Weight = 3f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new (2024, 7, 1), new (2024, 9, 1)],
                Price = 700000,
                Description = "A fluffy stupid cat.",
                ImageUrl = "https://furmily.vn/wp-content/uploads/2023/11/Thiet-ke-chua-co-ten-5-1.jpg",
                Discount = 0
            });
            AddCat(new Cat
            {
                CatId = "c003",
                Name = "harry",
                Breed = "Persian",
                Gender = true,
                Age = 2,
                Color = "golden",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4.5f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new(2023, 6, 1), new(2023, 7, 1)],
                Price = 12000000,
                Description = "A fluffy Persian cat.",
                ImageUrl = "http://images6.fanpop.com/image/photos/37000000/Persian-Kitten-cats-37009791-1280-1024.jpg",
                Discount = 0
            });
            _ = AddCat(new Cat
            {
                CatId = "c004",
                Name = "chuột",
                Breed = "Persian",
                Gender = true,
                Age = 2,
                Color = "golden",
                BirthDate = new DateOnly(2023, 5, 1),
                Weight = 4f,
                HealthStatus = "Healthy",
                IsDeworming = true,
                VaccinateDates = [new DateOnly(2023, 6, 1), new DateOnly(2023, 7, 1)],
                Price = 900000,
                Description = "A fluffy Persian cat.",
                ImageUrl = "http://images6.fanpop.com/image/photos/37000000/Persian-Kitten-cats-37009791-1280-1024.jpg",
                Discount = 0
            });
            
        }

        [HttpGet]
        public IActionResult GetAllCats([FromQuery] int? limit)
        {
             if (limit.HasValue && limit.Value > 0)
            {
                return Ok(cats.Take(limit.Value));
            }
            return Ok(cats);
        }

        [HttpGet("{id}")]
        public IActionResult GetCat(string id)
        {
            Cat? cat = cats.FirstOrDefault(c => c.CatId == id);
            if (cat == null)
            {
                return NotFound($"Cat with id {id} not found.");
            }
            return Ok(cat);
        }

        [HttpPost]
        public IActionResult AddCat(Cat cat)
        {
            if (cats.Any(c => c.CatId == cat.CatId))
            {
                return Conflict($"Cat with id {cat.CatId} already exists.");
            }

            cats.Add(cat);
            return CreatedAtAction(nameof(GetCat), new { id = cat.CatId }, cat);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCat(string id, Cat updatedCat)
        {
            Cat? existingCat = cats.FirstOrDefault(c => c.CatId == id);
            if (existingCat == null)
            {
                return NotFound($"Cat with id {id} not found.");
            }

            existingCat.Name = updatedCat.Name;
            existingCat.Breed = updatedCat.Breed;
            existingCat.Price = updatedCat.Price;
            existingCat.Description = updatedCat.Description;
            existingCat.ImageUrl = updatedCat.ImageUrl;
            
            return NoContent();
        }
    }
}