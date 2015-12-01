using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Slate.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Floorplan Designer";

            return View();
        }

        public ActionResult Budget()
        {
            ViewBag.Title = "Budget";
            return View();
        }

        
    }
}
