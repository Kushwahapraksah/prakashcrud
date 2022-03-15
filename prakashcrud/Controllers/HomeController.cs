using prakashcrud.db_prakash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prakashcrud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            prakashEntities obj = new prakashEntities();

            var obj1 = obj.empdetails.ToList();
            return View(obj1);
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