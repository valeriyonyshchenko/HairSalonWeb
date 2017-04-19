using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HairSalonWeb.DataBase;

namespace HairSalonWeb.Controllers
{
    public class IncomeMaterialHeadController : Controller
    {
        private HairSalonWebDataBaseEntities db = new HairSalonWebDataBaseEntities();

        // GET: IncomeMaterialHead
        public ActionResult Index()
        {
            return View(db.IncomeMaterialHead.ToList());
        }

        // GET: IncomeMaterialHead/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeMaterialHead incomeMaterialHead = db.IncomeMaterialHead.Find(id);
            if (incomeMaterialHead == null)
            {
                return HttpNotFound();
            }
            return View(incomeMaterialHead);
        }

        // GET: IncomeMaterialHead/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IncomeMaterialHead/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IncomeMaterialHeadId,InvoiceNumber,IncomeDate")] IncomeMaterialHead incomeMaterialHead)
        {
            if (ModelState.IsValid)
            {
                db.IncomeMaterialHead.Add(incomeMaterialHead);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incomeMaterialHead);
        }

        // GET: IncomeMaterialHead/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeMaterialHead incomeMaterialHead = db.IncomeMaterialHead.Find(id);
            if (incomeMaterialHead == null)
            {
                return HttpNotFound();
            }
            return View(incomeMaterialHead);
        }

        // POST: IncomeMaterialHead/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IncomeMaterialHeadId,InvoiceNumber,IncomeDate")] IncomeMaterialHead incomeMaterialHead)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incomeMaterialHead).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incomeMaterialHead);
        }

        // GET: IncomeMaterialHead/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeMaterialHead incomeMaterialHead = db.IncomeMaterialHead.Find(id);
            if (incomeMaterialHead == null)
            {
                return HttpNotFound();
            }
            return View(incomeMaterialHead);
        }

        // POST: IncomeMaterialHead/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IncomeMaterialHead incomeMaterialHead = db.IncomeMaterialHead.Find(id);
            db.IncomeMaterialHead.Remove(incomeMaterialHead);
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
