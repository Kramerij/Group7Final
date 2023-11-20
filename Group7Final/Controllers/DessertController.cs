﻿using Group7Final.Data;
using Microsoft.AspNetCore.Mvc;
using Group7Final.Models;
using Microsoft.EntityFrameworkCore;

//Lai Connelly
namespace Group7Final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DessertController : Controller
    {
        IDessert ctx;
        public DessertController(IDessert context)
        {
            ctx = context;
        }

        [HttpGet]
        [Route("api/getDesserts")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllDesserts());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetDessertById(id));
        }

        [HttpPost]
        public IActionResult Post(Dessert d)
        {
            var ret = ctx.AddDessert(d);
            if (ret == null)
            {
                return StatusCode(500, "A Dessert with this Id already exists.");
            }
            if (ret == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Dessert d)
        {
            var ret = ctx.UpdateDessert(d);

            if (ret == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var dessert = ctx.GetDessertById(id);
            if (dessert == null)
            {
                return NotFound(id);
            }
            var ret = ctx.RemoveDessertById(id);
            if (ret == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }

            return Ok();
        }
    }
}
