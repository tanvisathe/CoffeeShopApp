using CoffeeShopNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopNew.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Success(User u)
        {
            UsersController uc = new UsersController();
            uc.Create(u);
            if (ModelState.IsValid)

            {
                ViewBag.Firstname = "Welcome " + u.FirstName + " " + u.LastName;
                ViewBag.Email = "Your email " + u.Email + " is registered with us.  ";
                return View();
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}