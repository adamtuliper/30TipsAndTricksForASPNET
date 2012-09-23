using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _30TipsAndTricks.WebForms.Interfaces;
using _30TipsAndTricks.WebForms.Repositories;

namespace _30TipsAndTricks.WebForms
{
    public partial class ViewStates : System.Web.UI.Page
    {
        /// <summary>
        /// Property injection - note because of the PropertyInjection httpModule the properties are injected.
        /// Unfortunately we can't use constructor injection here, but this is second best.
        /// </summary>
        public IStateRepository Repository { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            statesList.DataSource = Repository.GetAll();
            statesList.DataBind();
        }
    }
}