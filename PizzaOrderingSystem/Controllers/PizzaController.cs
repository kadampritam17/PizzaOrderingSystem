using PizzaOrderingSystem.DAL;
using PizzaOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PizzaOrderingSystem.Controllers
{
    public class PizzaController : Controller
    {
        PizzaDbContext pizzaentities = new PizzaDbContext();
        // GET: Pizza
        public ActionResult Index()
        {
            List<Pizza> allPizza = pizzaentities.Pizza.ToList();
            this.ViewData["pizza"] = allPizza;
            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pizza = pizzaentities.Pizza.SingleOrDefault(p => p.Id == id);

            if (pizza == null)
            {
                return HttpNotFound();
            }
            this.ViewData["pizza"] = pizza;
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult Update(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pizza = pizzaentities.Pizza.SingleOrDefault(p => p.Id == id);

            if (pizza == null)
            {
                return HttpNotFound();
            }

            return View(pizza);

        }

        [Authorize]
        [HttpPost]
        public ActionResult Update(Pizza thePizza)
        {
            if (ModelState.IsValid)
            {
                pizzaentities.Entry(thePizza).State = System.Data.Entity.EntityState.Modified;
                pizzaentities.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thePizza);
        }

    }
}