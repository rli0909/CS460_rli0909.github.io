using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW8.Models;
using HW8.Models.ViewModel;

namespace HW8.Controllers
{
    public class ItemsController : Controller
    {
        private BusinessContext db = new BusinessContext();

        // GET: Items
        public ActionResult Index()
        {
            var items = db.Items.Include(i => i.Seller);
            return View(items.ToList());
        }

        // GET: Items/Details/5
        public ActionResult Details(int? id)
        {
           


            VM vm = new VM();
            vm.Bids = db.Items.Find(id).Bids;
            //vm.Bids.OrderByDescending(b => b.Price);
            //Same as 
            //db.Bids.Where(b => b.ItemID == id);

            int ItemID = db.Items.Find(id).ItemID;
            vm.Item = db.Items.Find(ItemID);

            ViewBag.display = false;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }

            
            if (vm.Bids.Count() > 0)
            {
                Debug.WriteLine("#####################################" + vm.Bids.Count());

                ViewBag.display = true;
                
                //int BidID = db.Bids.Find(id).BidID;
                //vm.Bids.OrderByDescending(b => b.Price);
            }
           
            return View(vm);
        }

        // GET: Items/Create
        public ActionResult Create()
        {
            ViewBag.SellerName = new SelectList(db.Sellers, "SellerName", "SellerName");
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemID,ItemName,ItemDescription,SellerName")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Items.Add(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SellerName = new SelectList(db.Sellers, "SellerName", "SellerName", item.SellerName);
            return View(item);
        }

        // GET: Items/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            ViewBag.SellerName = new SelectList(db.Sellers, "SellerName", "SellerName", item.SellerName);
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemID,ItemName,ItemDescription,SellerName")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SellerName = new SelectList(db.Sellers, "SellerName", "SellerName", item.SellerName);
            return View(item);
        }

        // GET: Items/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
