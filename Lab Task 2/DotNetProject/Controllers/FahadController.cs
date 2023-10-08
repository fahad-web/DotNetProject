using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetProject.Controllers
{
    
    public class FahadController : Controller
    {
        // GET: Protfolio
        public ActionResult Ashik() 
        { 
            ViewBag.Name = "Welcome";
            return View(); 
        }  
        public ActionResult Fahad()
        {
            ViewBag.Fahad = "MD Sahebuzzaman Fahad";
            ViewBag.ID = "20-43229-1";
            ViewBag.Gmail = "fk1946674@gmail.com";
            ViewBag.Phone = "01533781269";

            return View();
        }

        public ActionResult Education()
        {
            return View();
        }


        public ActionResult Project()
        {
            return View();
        }


        public ActionResult Referance()
        {
            return View();
        }


        public ActionResult Personal ()
        {
            return View();
        }
    }
}