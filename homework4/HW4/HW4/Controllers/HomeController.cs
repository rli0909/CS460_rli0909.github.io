﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            string mile = Request.Form["miles"];
            string unit = Request.Form["unit"];

            ViewBag.Message = mile + "&&&&&" + unit;
            return View();
        }


        public ActionResult ColorChooser()
        {
            return View();
        }
    }
}