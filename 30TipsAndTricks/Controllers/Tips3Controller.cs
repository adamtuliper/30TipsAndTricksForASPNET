using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using AttributeRouting.Web.Mvc;
using _30TipsAndTricks.Models;

namespace _30TipsAndTricks.Controllers
{
    public class Tips3Controller : Controller
    {
        //
        // GET: /Tips3/

        public ActionResult Index()
        {
            return View();
        }


        public ViewResult HiddenFieldSwitcher()
        {
            var customer = new CustomerViewModel();
            customer.CustomerId = 656;
            customer.FirstName = "Mary";
            customer.LastName = "Doe";
            customer.City = "Bethlehem";
            customer.State = "PA";
            customer.Zip = "18018";
            customer.EmailAddress = "mary@internal";

            return View(customer);
        }
        
        public ActionResult FormsAuthTimeouts()
        {
            return View();
        }

        public ActionResult Smtp()
        {
            //create the mail message
            MailMessage mail = new MailMessage();

            //set the addresses
            mail.From = new MailAddress("temp@gmail.com");
            mail.To.Add("temp@gmail.com");

            //set the content
            mail.Subject = "This is an email";
            mail.Body = "this is a sample body with html in it. <b>This is bold</b> <font color=#336699>This is blue</font>";
            mail.IsBodyHtml = true;

            //send the message
            SmtpClient smtp = new SmtpClient("127.0.0.1");
            smtp.Send(mail);
            return View();
        }

        public ViewResult PostSharpLogging()
        {
            return View();
        }

        [GET("Tips3/AttributeRoutingSample/{companyId}/{sortOrder?}/{page?}")]
        public ActionResult AttributeRoutingSample(int companyid, string sortOrder, int? page)
        {
            return View();
        }

        public ActionResult RemovingWebFormsViewEngine()
        {
            return View();
        }
        
        public ActionResult CdnFailoverToLocal()
        {
            return View();
        }

    }
}
