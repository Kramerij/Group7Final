using Group7Final.Data;
using Group7Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group7Final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MovieAPIController : ControllerBase
    {

        IMovieService ctx;
        public MovieAPIController(IMovieService context)
        {
            ctx = context;
        }


        [HttpGet]
        [Route("api/getmovies")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllMovies());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetMovieById(id));
        }
        [HttpPost]

        [HttpPut]

        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var product = ctx.GetMovieById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveMovieById(id); //generate remove product
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }

            return Ok();
        }
    }
}
