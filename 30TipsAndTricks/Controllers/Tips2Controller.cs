using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _30TipsAndTricks.Controllers
{
    public class Tips2Controller : Controller
    {
        //
        // GET: /Tips2/

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Intellitrace()
        {
            return View();
        }

        public ViewResult Elmah()
        {
            return View();
        }

        public ViewResult ElmahR()
        {
            return View();
        }

        public ActionResult ApplicationInitialization()
        {
            return View();
        }

        public ActionResult WhySessionsAreBad()
        {
            return View();
        }

        public ActionResult UsingAntiXss()
        {
            return View();
        }

        public ActionResult MiniProfiler()
        {
            using(var context = new EFContext())
            {
                var customer = context.Customers.First();
            }
            return View();
        }
    }
}
