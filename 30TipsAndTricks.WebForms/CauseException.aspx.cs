using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _30TipsAndTricks.WebForms
{
    public partial class CauseException : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Write("This is super secret information!!");
        }

        protected void btnException_Click(object sender, EventArgs e)
        {
            ProcessInsuranceForLeapYear(DateTime.Now,100);
        }

        private void ProcessInsuranceForLeapYear(DateTime checkDate, int maxYear)
        {
            DateTime today = DateTime.Now;
            int random = new Random(DateTime.Now.Millisecond).Next();
            int year = DateTime.Now.Year;
            if (!DateTime.IsLeapYear(year))
            {
                Response.Write("Not a leap year");
            }
            else
            {
              throw new Exception("UNKNOWN ERROR");
            }
        }
    }
}