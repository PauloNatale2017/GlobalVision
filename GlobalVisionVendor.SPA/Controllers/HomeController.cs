using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GlobalVisionVendor.SPA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Maps()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registers()
        {
            return View();
        }

        public ActionResult CadastroEnredecoLatLng()
        {
            return View();
        }

        public ActionResult DashBoard()
        {
            return View();
        }
    }
}
