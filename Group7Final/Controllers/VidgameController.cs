using Microsoft.AspNetCore.Mvc;
using Group7Final.Data;
using Group7Final.Models;

namespace Group7Final.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class VidgameController : Controller
	{
		IVidGameService _context;
		public VidgameController(IVidGameService context)
		{
			_context = context;
		}

		[HttpGet]
		[Route("api/getproducts")]
		public IActionResult Get()
		{
			return Ok(_context.GetAllGames());
		}
		[HttpGet("id")]
		public IActionResult Get(int id)
		{
			return Ok(_context.GetGameById(id));
		}
		[HttpPost]
		public IActionResult Post(Vidgame v)
		{
			var result = _context.AddGame(v);
			if (result == null)
			{
				return StatusCode(500, "A Product with this ID already exists");
			}
			if (result == 0)
			{
				return StatusCode(500, "An error occurred while processing your request");
			}
			return Ok();
		}
		[HttpPut]
		public IActionResult Put(Vidgame v)
		{
			var result = _context.UpdateGame(v);
			if (result == 0)
			{
				return StatusCode(500, "An error occurred while processing your request");
			}
			return Ok();
		}

		[HttpDelete]
		public IActionResult Delete(int id)
		{
			var product = _context.GetGameById(id);
			if (product == null)
			{
				return NotFound(id);
			}
			var result = _context.RemoveGameById(id);
			if (result == 0)
			{
				return StatusCode(500, "An error occurred while processing your request");
			}
			return Ok();
		}
	}
}
