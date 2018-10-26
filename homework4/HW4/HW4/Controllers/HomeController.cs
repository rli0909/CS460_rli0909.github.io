using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Text.RegularExpressions; // validate input value

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

        // Global variable for ARGB
        int mixA;
        int mixRed;
        int mixGreen;
        int mixBlue;

        [HttpPost]
        public ActionResult ColorChooser(string color1, string color2)
        {

            // Define a regular expression
            Regex rx = new Regex("^#(?:[0-9a-fA-F]{3}){1,2}$");

            Debug.WriteLine(color1 + "@@@@@@@@" + color2);

            bool matches1 = rx.IsMatch(color1);
            bool matches2 = rx.IsMatch(color2);

            Debug.WriteLine(color1 + "@@@@@@@@" + color2);

            // If the input format is Hex color value, then process input
            if (rx.IsMatch(color1) && rx.IsMatch(color2))
            {

                int a1 = ViewBag.color1 = ColorTranslator.FromHtml(color1).A;
                int a2 = ViewBag.color2 = ColorTranslator.FromHtml(color2).A;
                mixA = a1 + a2;
                if (mixA >= 255)
                {
                    mixA = 255;
                }

                int red1 = ViewBag.color1 = ColorTranslator.FromHtml(color1).R;
                int red2 = ViewBag.color1 = ColorTranslator.FromHtml(color2).R;

                mixRed = red1 + red2;
                if (mixRed >= 255)
                {
                    mixRed = 255;
                }

                int green1 = ViewBag.color1 = ColorTranslator.FromHtml(color1).G;
                int green2 = ViewBag.color1 = ColorTranslator.FromHtml(color2).G;
                mixGreen = green1 + green2;
                if (mixGreen >= 255)
                {
                    mixGreen = 255;
                }

                int blue1 = ViewBag.color1 = ColorTranslator.FromHtml(color1).B;
                int blue2 = ViewBag.color1 = ColorTranslator.FromHtml(color2).B;
                mixBlue = blue1 + blue2;
                if (mixBlue >= 255)
                {
                    mixBlue = 255;
                }
            }
            else
            {
                throw new FormatException();
            }
                
       

            //Get result color in ARGB structure
            Color result = Color.FromArgb(mixA, mixRed, mixGreen, mixBlue);
            string hexValue = ColorTranslator.ToHtml(result);
            ViewBag.mix = hexValue;

            //Convert value to ARGB
            //int colorValue = result.ToArgb();
            //ViewBag.mixValue = colorValue;


            //draw first color block
        




            ViewBag.color1 = color1;  //return A value
            ViewBag.color2 = color2;  //return B value



            return View();
        }
    }
}