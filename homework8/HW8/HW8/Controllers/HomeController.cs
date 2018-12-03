using HW8.Models;
using HW8.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW8.Controllers
{
    public class HomeController : Controller
    {
        private BusinessContext db = new BusinessContext();
        public ActionResult Index()
        {
            VM vm = new VM();
            vm.Bids = db.Bids.Take(10).OrderByDescending(v => v.Timestamp);
            return View(vm);
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
    }
}