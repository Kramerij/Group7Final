using Microsoft.AspNetCore.Mvc;

namespace Group7Final.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
