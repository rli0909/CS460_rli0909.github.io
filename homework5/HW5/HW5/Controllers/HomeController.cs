using HW5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HW5.Controllers
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


        public ActionResult SeeRequest()
        {
            Request model = new Request { FirstName = "Lucy", LastName = "Lee", PhoneNum = "503-851-1885", AptName = "Kingston", Unit = 4, Expl = "Repair shower head"};
            Debug.WriteLine(model);
            return View(model);
        }
    }
}