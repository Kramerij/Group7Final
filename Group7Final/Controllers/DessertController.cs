using Group7Final.Data;
using Microsoft.AspNetCore.Mvc;
using Group7Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Group7Final.Controllers
{
    public class DessertController : Controller
    {
        FinalContext ctx;
        public DessertController(FinalContext context) { ctx = context; }

        public IActionResult Index()
        {
            ViewData["Desserts"] = ctx.Desserts.ToList();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Dessert model)
        {
            ctx.Desserts.Add(model);
            ctx.SaveChanges();
            ViewBag.Message = "Data Insert Successful";
            return View();
        }

        public ActionResult Read(int? id)
        {
            if (id != null || id > 0)
            {
                return View(ctx.Desserts.Where(x => x.Id == id).FirstOrDefault());
            }
            else
            {
                return View(ctx.Desserts.Take(5).FirstOrDefault());
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var data = ctx.Desserts.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Update(Dessert Model)
        {
            var data = ctx.Desserts.Where(x => x.Id == Model.Id).FirstOrDefault();
            if (data != null)
            {
                data.TeamMember = Model.TeamMember;
                data.DessertName = Model.DessertName;
                data.DessertType = Model.DessertType;
                data.DessertTemp = Model.DessertTemp;
                ctx.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var data = ctx.Desserts.Where(x => x.Id == id).FirstOrDefault();
            ctx.Desserts.Remove(data);
            ctx.SaveChanges();
            ViewBag.Message = "Record Delete Successful";
            return RedirectToAction("Index");
        }
    }
}
