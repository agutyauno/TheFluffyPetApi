using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheFluffyPetApi.models;

namespace TheFluffyPetApi.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartsController : ControllerBase
    {
        static readonly List<Cart> carts = [];

        [HttpGet]
        public IActionResult GetCarts()
        {
            return Ok(carts);
        }

        [HttpPost]
        public IActionResult AddCart(Cart cart)
        {
            carts.Add(cart);
            return CreatedAtAction(nameof(GetCarts), new { id = cart.Name }, cart);
        }
    }
}