using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HairSalonWeb.DataBase;
using static System.IO.File;

namespace HairSalonWeb.Controllers
{
    public class HomeController : Controller
    {
        private HairSalonWebDataBaseEntities db = new HairSalonWebDataBaseEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            var sql = ReadAllText(Server.MapPath(@"~/DataBase/SQL_Create.txt"));
            db.Database.ExecuteSqlCommand(sql);
            
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Insert()
        {
            var sql = ReadAllText(Server.MapPath(@"~/DataBase/SQL_Insert.txt"));
            db.Database.ExecuteSqlCommand(sql);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Drop()
        {
            var sql = ReadAllText(Server.MapPath(@"~/DataBase/SQL_Drop.txt"));
            db.Database.ExecuteSqlCommand(sql);

            return RedirectToAction("Index", "Home");
        }
    }
}