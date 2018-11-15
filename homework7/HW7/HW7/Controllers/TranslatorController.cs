using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW7.Controllers
{
    public class TranslatorController : Controller
    {
        //GET: HOME
        public ActionResult Index()
        {
            return View();
        }



        // GET: User inputs
        public JsonResult Translate(string id)
        {
            var data = new
            {
                message = (string) id,
                input = (string) id,
                // How to get stickers according to the input?
            };

            // AJAX call to server
            // How to do AJAX call in controllor
          

            return Json(data, JsonRequestBehavior.AllowGet );
        }
    }
}