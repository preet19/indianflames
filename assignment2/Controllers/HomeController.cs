using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assignment2.Controllers
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

        public ActionResult Menu()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult chickenTikka()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult dalMakhni()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult mangoLassi()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Indian flame.";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Admin user.";

            return View();
        }


    }
}