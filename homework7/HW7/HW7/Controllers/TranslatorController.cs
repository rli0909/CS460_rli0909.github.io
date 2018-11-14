using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW7.Controllers
{
    public class TranslatorController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: User inputs
        public ActionResult Translate(string words)
        {


            return View( words );
        }
    }
}