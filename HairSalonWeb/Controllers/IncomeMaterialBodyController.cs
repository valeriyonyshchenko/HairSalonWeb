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
    public class IncomeMaterialBodyController : Controller
    {
        private HairSalonWebDataBaseEntities db = new HairSalonWebDataBaseEntities();

        // GET: IncomeMaterialBody
        public ActionResult Index()
        {
            var incomeMaterialBody = db.IncomeMaterialBody.Include(i => i.Brand).Include(i => i.MaterialType);
            return View(incomeMaterialBody.ToList());
        }

        // GET: IncomeMaterialBody/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeMaterialBody incomeMaterialBody = db.IncomeMaterialBody.Find(id);
            if (incomeMaterialBody == null)
            {
                return HttpNotFound();
            }
            return View(incomeMaterialBody);
        }

        // GET: IncomeMaterialBody/Create
        public ActionResult Create()
        {
            ViewBag.BrandId = new SelectList(db.Brand, "BrandId", "Name");
            ViewBag.MaterialTypeId = new SelectList(db.MaterialType, "MaterialTypeId", "Name");
            return View();
        }

        // POST: IncomeMaterialBody/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IncomeMaterialBodyId,Name,Count,PurchaseCost,RetailCost,MaterialTypeId,BrandId")] IncomeMaterialBody incomeMaterialBody)
        {
            if (ModelState.IsValid)
            {
                db.IncomeMaterialBody.Add(incomeMaterialBody);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BrandId = new SelectList(db.Brand, "BrandId", "Name", incomeMaterialBody.BrandId);
            ViewBag.MaterialTypeId = new SelectList(db.MaterialType, "MaterialTypeId", "Name", incomeMaterialBody.MaterialTypeId);
            return View(incomeMaterialBody);
        }

        // GET: IncomeMaterialBody/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeMaterialBody incomeMaterialBody = db.IncomeMaterialBody.Find(id);
            if (incomeMaterialBody == null)
            {
                return HttpNotFound();
            }
            ViewBag.BrandId = new SelectList(db.Brand, "BrandId", "Name", incomeMaterialBody.BrandId);
            ViewBag.MaterialTypeId = new SelectList(db.MaterialType, "MaterialTypeId", "Name", incomeMaterialBody.MaterialTypeId);
            return View(incomeMaterialBody);
        }

        // POST: IncomeMaterialBody/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IncomeMaterialBodyId,Name,Count,PurchaseCost,RetailCost,MaterialTypeId,BrandId")] IncomeMaterialBody incomeMaterialBody)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incomeMaterialBody).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BrandId = new SelectList(db.Brand, "BrandId", "Name", incomeMaterialBody.BrandId);
            ViewBag.MaterialTypeId = new SelectList(db.MaterialType, "MaterialTypeId", "Name", incomeMaterialBody.MaterialTypeId);
            return View(incomeMaterialBody);
        }

        // GET: IncomeMaterialBody/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeMaterialBody incomeMaterialBody = db.IncomeMaterialBody.Find(id);
            if (incomeMaterialBody == null)
            {
                return HttpNotFound();
            }
            return View(incomeMaterialBody);
        }

        // POST: IncomeMaterialBody/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IncomeMaterialBody incomeMaterialBody = db.IncomeMaterialBody.Find(id);
            db.IncomeMaterialBody.Remove(incomeMaterialBody);
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
