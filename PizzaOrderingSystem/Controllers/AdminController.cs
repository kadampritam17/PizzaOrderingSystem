using PizzaOrderingSystem.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PizzaOrderingSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password, string returnUrl)
        {
            AccountManager account = new AccountManager();

            //validation logic for admin login
            bool status = account.ValidateAdmin(email, password);

            if (status)
            {
                //set cookiee
                FormsAuthentication.SetAuthCookie(email, false);
                //on success redirection to url
                return Redirect(returnUrl ?? Url.Action("Index", "Home"));
            }
            else
                //on fail redirection to same url
                return View();
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}