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
    public class ChallanEntryController : Controller
    {
        private BRCTransportDBEntities db = new BRCTransportDBEntities();

        //
        // GET: /ChallanEntry/

        public ActionResult Index()
        {
            var tblchallanentries = db.tblChallanEntries.Include(t => t.tblChallan);
            return View(tblchallanentries.ToList());
        }

        //
        // GET: /ChallanEntry/Details/5

        public ActionResult Details(int id = 0)
        {
            tblChallanEntry tblchallanentry = db.tblChallanEntries.Find(id);
            if (tblchallanentry == null)
            {
                return HttpNotFound();
            }
            return View(tblchallanentry);
        }

        //
        // GET: /ChallanEntry/Create

        public ActionResult Create()
        {
            ViewBag.ChallanNo = new SelectList(db.tblChallans, "ChallanNo", "VehicleNo");
            return View();
        }

        //
        // POST: /ChallanEntry/Create

        [HttpPost]
        public ActionResult Create(tblChallanEntry tblchallanentry)
        {
            if (ModelState.IsValid)
            {
                db.tblChallanEntries.Add(tblchallanentry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ChallanNo = new SelectList(db.tblChallans, "ChallanNo", "VehicleNo", tblchallanentry.ChallanNo);
            return View(tblchallanentry);
        }

        //
        // GET: /ChallanEntry/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tblChallanEntry tblchallanentry = db.tblChallanEntries.Find(id);
            if (tblchallanentry == null)
            {
                return HttpNotFound();
            }
            ViewBag.ChallanNo = new SelectList(db.tblChallans, "ChallanNo", "VehicleNo", tblchallanentry.ChallanNo);
            return View(tblchallanentry);
        }

        //
        // POST: /ChallanEntry/Edit/5

        [HttpPost]
        public ActionResult Edit(tblChallanEntry tblchallanentry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblchallanentry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ChallanNo = new SelectList(db.tblChallans, "ChallanNo", "VehicleNo", tblchallanentry.ChallanNo);
            return View(tblchallanentry);
        }

        //
        // GET: /ChallanEntry/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tblChallanEntry tblchallanentry = db.tblChallanEntries.Find(id);
            if (tblchallanentry == null)
            {
                return HttpNotFound();
            }
            return View(tblchallanentry);
        }

        //
        // POST: /ChallanEntry/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tblChallanEntry tblchallanentry = db.tblChallanEntries.Find(id);
            db.tblChallanEntries.Remove(tblchallanentry);
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