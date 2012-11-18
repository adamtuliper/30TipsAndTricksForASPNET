using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace _30TipsAndTricks.Controllers
{
    //[SessionState(SessionStateBehavior.ReadOnly)]
    public class SessionIssuesController : Controller
    {
        //
        // GET: /SessionIssues/
        public ActionResult PlainPage()
        {
            return Content(DateTime.Now.ToString());
        }

        public ActionResult CauseDelay()
        {
            Thread.Sleep(5000);
            return Content(DateTime.Now.ToString());
        }

        public ActionResult CauseDelayWithSession()
        {
            DateTime startTime = DateTime.Now;
            Session["FromSession"] = DateTime.Now;
            Thread.Sleep(5000);
            return Content(string.Format("Should have taken five seconds - took: {0}<br>Current Time: {1}", DateTime.Now.Subtract(startTime).Seconds, DateTime.Now));
        }

        public ActionResult CauseDelayWithTempData()
        {
            DateTime startTime = DateTime.Now;
            TempData["FromTempData"] = DateTime.Now;
            Thread.Sleep(5000);
            return Content(string.Format("Should have taken five seconds, took:{3}<br>TempData: {0} Session:{1}  Now: {2}", TempData["FromTempData"], Session["FromSession"], DateTime.Now, DateTime.Now.Subtract(startTime).Seconds));
        }

    }
}
