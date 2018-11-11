using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW6.Models;

namespace HW6.Controllers
{
    public class PeopleController : Controller
    {
        private EFContext db = new EFContext();

        // GET: People
        //public ActionResult Index()
        //{
        //  var people = db.People.Include(p => p.Person1);

        // return View(people.ToList());
        //}

        // GET
        [HttpGet]
        public ActionResult Search(string name)
        {
            name = Request.QueryString["name"];
            if (name == null)
            {
                ViewBag.display = false;
                return View();
            }
            else
            {
                ViewBag.display = true;
                IEnumerable<Person> results = db.People.Where(p => p.SearchName.Contains(name));
                List<Person> people = results.ToList();
                return View(people);
            }
        }

        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

   
            Person p = db.People.Find(id);
            ViewBag.pFound = false;
            if (p == null)
            {
                return HttpNotFound();
            }

            if (p.Customers.Count() > 0)
            {
                ViewBag.pFound = true;
                int ID = p.Customers.FirstOrDefault().CustomerID;
    

            }
            return View(p);
        }
    }
}