using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Version1;
using _30TipsAndTricks.Models;

namespace _30TipsAndTricks.Controllers
{
    public class Tips1Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ViewResult FusionLog()
        {
            //create some invalid assembly reference.
            //var assembly = Assembly.Load("I dont exist.dll");
            var customer = new Version1.Customer();
            customer.Name = "Mary Doe";
            customer.Address = "555 Main St.";
            //customer.EmailAddress = "mary@nowhere.com";
            return View(customer);

        }

        public ActionResult CauseException()
        {
            throw new Exception("Any exception - see the YSOD? Bad error handling, go sit in the corner!");
        }

        public ViewResult RetailMode()
        {
            return View();
        }

        public ViewResult Minification()
        {
            return View();
        }
        
        public ViewResult Bundling()
        {
            return View();
        }
       
        public ViewResult InstallSsl()
        {
            return View();
        }

        public ViewResult ForceSsl()
        {
            return View();
        }

        [RequireHttps]
        public ViewResult InstallSslSecured()
        {
            return View();
        }

    }
}
