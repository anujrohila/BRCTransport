using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BRCTransport.Web.Models;

namespace BRCTransport.Web.Controllers
{
    public class BillEntryController : Controller
    {
        private BRCTransportDBEntities db = new BRCTransportDBEntities();

        //
        // GET: /BillEntry/

        public ActionResult Index()
        {
            var tblbillentries = db.tblBillEntries.Include(t => t.tblBill);
            return View(tblbillentries.ToList());
        }

        //
        // GET: /BillEntry/Details/5

        public ActionResult Details(string id = null)
        {
            tblBillEntry tblbillentry = db.tblBillEntries.Find(id);
            if (tblbillentry == null)
            {
                return HttpNotFound();
            }
            return View(tblbillentry);
        }

        //
        // GET: /BillEntry/Create

        public ActionResult Create()
        {
            ViewBag.BillNo = new SelectList(db.tblBills, "BillNo", "BillDate");
            return View();
        }

        //
        // POST: /BillEntry/Create

        [HttpPost]
        public ActionResult Create(tblBillEntry tblbillentry)
        {
            if (ModelState.IsValid)
            {
                db.tblBillEntries.Add(tblbillentry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BillNo = new SelectList(db.tblBills, "BillNo", "BillDate", tblbillentry.BillNo);
            return View(tblbillentry);
        }

        //
        // GET: /BillEntry/Edit/5

        public ActionResult Edit(string id = null)
        {
            tblBillEntry tblbillentry = db.tblBillEntries.Find(id);
            if (tblbillentry == null)
            {
                return HttpNotFound();
            }
            ViewBag.BillNo = new SelectList(db.tblBills, "BillNo", "BillDate", tblbillentry.BillNo);
            return View(tblbillentry);
        }

        //
        // POST: /BillEntry/Edit/5

        [HttpPost]
        public ActionResult Edit(tblBillEntry tblbillentry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblbillentry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BillNo = new SelectList(db.tblBills, "BillNo", "BillDate", tblbillentry.BillNo);
            return View(tblbillentry);
        }

        //
        // GET: /BillEntry/Delete/5

        public ActionResult Delete(string id = null)
        {
            tblBillEntry tblbillentry = db.tblBillEntries.Find(id);
            if (tblbillentry == null)
            {
                return HttpNotFound();
            }
            return View(tblbillentry);
        }

        //
        // POST: /BillEntry/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            tblBillEntry tblbillentry = db.tblBillEntries.Find(id);
            db.tblBillEntries.Remove(tblbillentry);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}