using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
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

        [HttpGet]
        public ActionResult Converter()
        {
            string mile = Request.QueryString["miles"];
            string unit = Request.QueryString["unit"];

            float miles = 0.0f;
            float units = 0.0f;

            if (mile != null && unit != null)
            {
                miles = float.Parse(mile);
                units = float.Parse(unit);
            }

            float result = miles * units;

            if (unit == "1609344")
            {
                ViewBag.Message = miles + " miles " + " is equals to " + result + " millimeters";
            }
            else if (unit == "160934.4")
            {
                ViewBag.Message = miles + " miles " + " is equals to " + result + " centimeters";
            }
            else if (unit == "1609.344")
            {
                ViewBag.Message = miles + " miles " + " is equals to " + result + " meters";
            }
            else if (unit == "1.609344")
            {
                ViewBag.Message = miles + " miles " + " is equals to " + result + " kilometers";
            }

            return View();
        }

        public ActionResult ColorChooser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ColorChooser(Color color1, Color color2)
        {

            string htmlColor1 = ColorTranslator.ToHtml(color1);
            string htmlColor2 = ColorTranslator.ToHtml(color2);

            return View();
        }
    }
}