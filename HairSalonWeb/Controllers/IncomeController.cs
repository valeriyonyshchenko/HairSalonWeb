using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using HairSalonWeb.DataBase;
using HairSalonWeb.Models;

namespace HairSalonWeb.Controllers
{
    public class IncomeController : Controller
    {
        private HairSalonWebDataBaseEntities db = new HairSalonWebDataBaseEntities();

        public ActionResult Index(int? id)
        {
            var model = new IncomeModel
            {
                Head = db.IncomeMaterialHead.ToList()
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