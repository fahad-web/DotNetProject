using DotNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetProject.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Sinup() 
        {
            /*ViewBag.date = DateTime.Today;*/
            return View();
        }

        [HttpPost]
        public ActionResult Sinup(Sinup sn)
        {
            return View(sn);
        }

        /*public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Sinup lg)
        {
            return View(lg);
        }*/

        /*[HttpPost]
        public ActionResult Login(FormCollection l)
        {
            ViewBag.name = l["Name"];
            ViewBag.id = l["ID"];
            ViewBag.gender = l["Gender"];
            ViewBag.profession = l["Profession"];
            ViewBag.hobb = l["Hobb"];
            return View();
        }*/
    }
}