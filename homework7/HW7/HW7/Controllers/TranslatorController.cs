using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace HW7.Controllers
{
    public class TranslatorController : Controller
    {

        // client object
       // static HttpClient client = new HttpClient();

       // var api = "http://api.giphy.com/v1/gifs/translate?";
       // var apiKey = "&api_key=gMrqiddCIe001wwIeLKG0llVIXfOKmh9";

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
            //var url = api + apiKey + "&s=" + id;

            //response = client.GetAsync(url);
           // if (response.IsSuccessStatusCode)
           // {

          //  }


            return Json(data, JsonRequestBehavior.AllowGet );
        }
    }
}