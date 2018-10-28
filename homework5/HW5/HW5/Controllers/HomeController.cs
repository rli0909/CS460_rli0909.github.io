using HW5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW5.DAL;


namespace HW5.Controllers
{
    public class HomeController : Controller
    {
        public RequestCollection rc = new RequestCollection();
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


        public ActionResult ALLRequests()
        {
            return View(rc.Requests);
        }

        // GET-POST-Redirect to GET
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Request r)
        {
            Debug.WriteLine(r);
            if (ModelState.IsValid)
            {
                rc.Requests.Add(r);
                return RedirectToAction("AllRequests");
            }
            return View();
        }
    }
}