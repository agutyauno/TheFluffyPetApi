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