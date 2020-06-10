using CattlewatchAppFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CattlewatchAppFinal.Controllers
{
    public class ClientController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Client
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult GetEstimate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetEstimate(Order order)
        {

            var livestock = order.SelectedLivestock.ToList();
            order.Orderstatus = "Estimate";
            db.Orders.Add(order);
            

            foreach (var item in livestock)
            {
                if (ModelState.IsValid)
                {
                    LivestockOrder ls = new LivestockOrder();
                    ls.OrderId = order.OrderId;
                    db.LivestockOrders.Add(ls);
                    db.SaveChanges();
                    var itemremove = livestock.FirstOrDefault();
                    livestock.Remove(itemremove);
                }
            }
            return View();
        }
        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
