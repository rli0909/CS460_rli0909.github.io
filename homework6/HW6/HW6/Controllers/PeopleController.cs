using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using HW6.Models;
using HW6.Models.ViewModel;

namespace HW6.Controllers
{
    public class PeopleController : Controller
    {
        // Context file connect to db
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
                //IEnumerable<Person> results = db.People.Where(p => p.SearchName.Contains(name));
                //List<Person> people = results.ToList();
                //return View(people);
                return View(db.People.Where(p => p.FullName.Contains(name)).ToList());
            }
        }

        // GET: People/Details/5
        public ActionResult Details(int? id)
        {
            ViewModel vm = new ViewModel();

            vm.Person = db.People.Find(id);

            ViewBag.found = false;

            Person p = db.People.Find(id);


            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (p == null)
            {
                // ViewBag.display = false;
                return HttpNotFound();
            }

            if (vm.Person.Customers2.Count() > 0)
            {
                ViewBag.found = true;
                //Debug.WriteLine("pFound is true");
                int ID = vm.Person.Customers2.FirstOrDefault().CustomerID;

                // find person from Customers model with ID and set to Customer in ViewModel
                vm.Customer = db.Customers.Find(ID);

                ViewBag.GrossSales = vm.Customer.Orders.SelectMany(i => i.Invoices)
                                                       .SelectMany(il => il.InvoiceLines)
                                                       .Sum(s => s.ExtendedPrice);

                ViewBag.GrossProfit = vm.Customer.Orders.SelectMany(i => i.Invoices)
                                                        .SelectMany(il => il.InvoiceLines)
                                                        .Sum(lp => lp.LineProfit);

                vm.InvoiceLine = vm.Customer.Orders.SelectMany(i => i.Invoices)
                                                   .SelectMany(il => il.InvoiceLines)
                                                   .OrderByDescending(lp => lp.LineProfit)
                                                   .Take(10).ToList();
            }

            return View(vm);
        }
    }
}