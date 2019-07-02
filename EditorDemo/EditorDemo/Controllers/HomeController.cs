using EditorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace EditorDemo.Controllers
{
    public class HomeController : Controller
    {
        private EditorDemoEntities db = new EditorDemoEntities();

        public ActionResult Index()
        {
            string cName = Thread.CurrentThread.CurrentUICulture.Name;

            return View(db.Packages.ToList());
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
    }
}