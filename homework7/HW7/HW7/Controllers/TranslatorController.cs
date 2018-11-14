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
        public JsonResult Translate(string words)
        {
            var data = new
            {
                message = "Hello from translator",
                input = (string) words,
                // How to get stickers according to the input?
            };

            return Json(data, JsonRequestBehavior.AllowGet );
        }
    }
}