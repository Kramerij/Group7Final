using Group7Final.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Group7Final.Controllers
{
    public class MovieController : Controller
    {
        FinalContext ctx;
        public MovieController(FinalContext context) { 
            ctx = context;
        }
        [HttpGet]

        [HttpGet("id")]

        [HttpPost]

        [HttpPut]

        [HttpDelete]
        public IActionResult Index()
        {
            return View();
        }
    }
}
