using DotNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetProject.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            Company c = new Company();
            c.Name = "Web Development";

            /*ViewBag.Company = c;*/ /*field variable, property,*/ 
            return View(c);
        }
        public ActionResult Project()
        {
            ViewBag.project1 = "Web Develepment";
            ViewBag.client1 = "MD Fahad";
            ViewBag.project2 = "Protfolio";
            ViewBag.client2 = "MD Ashik";
            ViewBag.project3 = "ASP.NET MVC Project";
            ViewBag.client3 = "MD Abid";

            return View();
        }
        public ActionResult Team()
        {
            return View();
        }

    }
}