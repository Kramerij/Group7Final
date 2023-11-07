using Group7Final.Data;
using Microsoft.AspNetCore.Mvc;
using Group7Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Group7Final.Controllers
{
    public class DessertController : Controller
    {
        private FinalContext context;

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Dessert model)
        {
            context.Desserts.Add(model);
            context.SaveChanges();
            ViewBag.Message = "Data Insert Successful";
            return View();
        }

        public ActionResult Read(int? id)
        {
            if (id != null || id > 0)
            {
                return View(context.Desserts.Where(x => x.Id == id).FirstOrDefault());
            }
            else
            {
                return View(context.Desserts.Take(5).FirstOrDefault());
            }
        }

        [HttpGet]
        public ActionResult Update(int id) 
        { 
            var data = context.Desserts.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Update(Dessert Model)
        {
            var data = context.Desserts.Where(x => x.Id == Model.Id).FirstOrDefault();
            if (data != null)
            {
                data.TeamMember = Model.TeamMember;
                data.DessertName = Model.DessertName;
                data.DessertType = Model.DessertType;  
                data.DessertTemp = Model.DessertTemp;
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var data = context.Desserts.Where(x => x.Id == id).FirstOrDefault();
            context.Desserts.Remove(data);
            context.SaveChanges();
            ViewBag.Message = "REcord Delete Successful";
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
