using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CattlewatchAppFinal.Models;

namespace CattlewatchAppFinal.Controllers
{
    public class LivestockOrdersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LivestockOrders
        public ActionResult Index()
        {
            var livestockOrders = db.LivestockOrders.Include(l => l.Livestock).Include(l => l.Location).Include(l => l.Order);
            return View(livestockOrders.ToList());
        }

        // GET: LivestockOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LivestockOrder livestockOrder = db.LivestockOrders.Find(id);
            if (livestockOrder == null)
            {
                return HttpNotFound();
            }
            return View(livestockOrder);
        }

        // GET: LivestockOrders/Create
        public ActionResult Create()
        {
            ViewBag.LivestockId = new SelectList(db.Livestocks, "LivestockId", "livestockName");
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Latitude");
            ViewBag.OrderId = new SelectList(db.Orders, "OrderId", "ClientName");
            return View();
        }

        // POST: LivestockOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LivestoOrderckId,numberOfLivestock,LivestockId,OrderId,LocationId")] LivestockOrder livestockOrder)
        {
            if (ModelState.IsValid)
            {
                db.LivestockOrders.Add(livestockOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LivestockId = new SelectList(db.Livestocks, "LivestockId", "livestockName", livestockOrder.LivestockId);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Latitude", livestockOrder.LocationId);
            ViewBag.OrderId = new SelectList(db.Orders, "OrderId", "ClientName", livestockOrder.OrderId);
            return View(livestockOrder);
        }

        // GET: LivestockOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LivestockOrder livestockOrder = db.LivestockOrders.Find(id);
            if (livestockOrder == null)
            {
                return HttpNotFound();
            }
            ViewBag.LivestockId = new SelectList(db.Livestocks, "LivestockId", "livestockName", livestockOrder.LivestockId);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Latitude", livestockOrder.LocationId);
            ViewBag.OrderId = new SelectList(db.Orders, "OrderId", "ClientName", livestockOrder.OrderId);
            return View(livestockOrder);
        }

        // POST: LivestockOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LivestoOrderckId,numberOfLivestock,LivestockId,OrderId,LocationId")] LivestockOrder livestockOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livestockOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LivestockId = new SelectList(db.Livestocks, "LivestockId", "livestockName", livestockOrder.LivestockId);
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Latitude", livestockOrder.LocationId);
            ViewBag.OrderId = new SelectList(db.Orders, "OrderId", "ClientName", livestockOrder.OrderId);
            return View(livestockOrder);
        }

        // GET: LivestockOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LivestockOrder livestockOrder = db.LivestockOrders.Find(id);
            if (livestockOrder == null)
            {
                return HttpNotFound();
            }
            return View(livestockOrder);
        }

        // POST: LivestockOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LivestockOrder livestockOrder = db.LivestockOrders.Find(id);
            db.LivestockOrders.Remove(livestockOrder);
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
