using Microsoft.AspNetCore.Mvc;
using Group7Final.Data;
using Group7Final.Models;

namespace Group7Final.Controllers
{
    // Jacob Junker

    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : Controller
    {

        ITeamService ctx;
        public TeamController(ITeamService context)
        {
            ctx = context;
        }

        [HttpGet]
        [Route("getTeam")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllTeams());
        }
        [HttpGet("getTeamByID")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetTeamById(id));
        }
        [HttpPost]
        [Route("AddTeam")]
        public IActionResult Post(Team t)
        {
            var result = ctx.AddTeam(t);
            if (result == null)
            {
                return StatusCode(500, "a team member with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
        [HttpPut]
        [Route("updateTeam")]
        public IActionResult Put(Team t)
        {
            var result = ctx.UpdateTeam(t);

            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
        [HttpDelete]
        [Route("DeleteTeam")]
        public IActionResult Delete(int id)
        {
            var product = ctx.GetTeamById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveTeamById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }

            return Ok();
        }
    }
}
