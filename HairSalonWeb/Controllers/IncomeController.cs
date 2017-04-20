using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using HairSalonWeb.DataBase;
using HairSalonWeb.Models;
using Microsoft.Ajax.Utilities;

namespace HairSalonWeb.Controllers
{
    public class IncomeController : Controller
    {
        private HairSalonWebDataBaseEntities db = new HairSalonWebDataBaseEntities();

        public ActionResult Index(int? id, string sortOrder)
        {
                ViewBag.InvoiceNumberSortParm = sortOrder == "InvoiceNumber" ? "InvoiceNumber_desc" : "InvoiceNumber";
                ViewBag.IncomeDateSortParm = sortOrder == "IncomeDate" ? "IncomeDate_desc" : "IncomeDate";

            var head = db.IncomeMaterialHead.ToList();

            switch (sortOrder)
            {
                case "InvoiceNumber":
                    head = head.OrderBy(x => x.InvoiceNumber).ToList();
                    break;
                case "InvoiceNumber_desc":
                    head = head.OrderByDescending(x => x.InvoiceNumber).ToList();
                    break;
                case "IncomeDate":
                    head = head.OrderBy(x => x.IncomeDate).ToList();
                    break;
                //case "IncomeDate_desc":
                //    head = head.OrderByDescending(x => x.IncomeDate).ToList();
                //    break;
                default:
                    head = head.OrderBy(x => x.InvoiceNumber).ToList();
                    break;
            }

            var model = new IncomeModel
            {
                Head = head
            };

            if (id != null)
            {
                ViewBag.HeadId = id;
                model.Body = db.IncomeMaterial.Where(x => x.IncomeMaterialHeadId == id)
                    .Select(x => x.IncomeMaterialBody)
                    .Include(i => i.Brand).Include(i => i.MaterialType)
                    .ToList();
            }

            return View(model);
        }
        
        public ActionResult CreateHead()
        {
            throw new NotImplementedException();
        }

        public ActionResult EditHead(object id)
        {
            throw new NotImplementedException();
        }

        public ActionResult DetailsHead(object id)
        {
            throw new NotImplementedException();
        }

        public ActionResult DeleteHead(object id)
        {
            throw new NotImplementedException();
        }

        public ActionResult CreateBody()
        {
            throw new NotImplementedException();
        }

        public ActionResult EditBody(object id)
        {
            throw new NotImplementedException();
        }

        public ActionResult DetailsBody(object id)
        {
            throw new NotImplementedException();
        }

        public ActionResult DeleteBody(object id)
        {
            throw new NotImplementedException();
        }
    }
}