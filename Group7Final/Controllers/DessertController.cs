using Group7Final.Data;
using Microsoft.AspNetCore.Mvc;
using Group7Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Group7Final.Controllers
{
    public class DessertController : Controller
    {
        private List<Dessert> sweet;
        public DessertController ()
        {
            sweet = new List<Dessert>();
            {
                new Dessert()
                { DessertId = 1, TeamMember = "Isabelle", DessertName = "Brownie Cheesecake", DessertType = "Cheesecake", DessertTemp = "Cold" };
                new Dessert()
                { DessertId = 2, TeamMember = "Lai", DessertName = "Dulce De Leche Cheesecake", DessertType = "Cheesecake", DessertTemp = "Cold" };
                new Dessert()
                { DessertId = 3, TeamMember = "Eli", DessertName = "Maple Eclair", DessertType = "Donut", DessertTemp = "Hot" };
                new Dessert()
                { DessertId = 4, TeamMember = "Danny", DessertName = "Mint Chocolate Chip Malt", DessertType = "Ice Cream", DessertTemp = "Cold" };
                new Dessert()
                { DessertId = 5, TeamMember = "Jack", DessertName = "Rock", DessertType = "Rock", DessertTemp = "Hot" };
            }
        }

        public IActionResult Index()
        {
            return View(sweet);
        }
    }
}
