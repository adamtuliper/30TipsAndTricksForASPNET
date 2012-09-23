using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Autofac;
using Autofac.Integration.Web;
using _30TipsAndTricks.WebForms;
using _30TipsAndTricks.WebForms.Cache;
using _30TipsAndTricks.WebForms.Interfaces;
using _30TipsAndTricks.WebForms.Repositories;

namespace _30TipsAndTricks.WebForms
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        /// <summary>
        /// Provider that holds the application container.
        /// </summary>
        private static IContainerProvider _containerProvider;

        /// <summary>
        /// Instance property that will be used by Autofac HttpModules to resolve and inject dependencies.
        /// </summary>
        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();

            //*********************************
            //Autofac specific code
            var builder = new ContainerBuilder();
            builder.RegisterType<MemoryCacheProvider>().As<ICacheProvider>().InstancePerLifetimeScope();
            builder.RegisterType<StateRepository>().As<IStateRepository>().InstancePerLifetimeScope();
            // ... continue registering dependencies and then build the
            // container provider...
            _containerProvider = new ContainerProvider(builder.Build());
            //*********************************
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        protected void Application_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            //Only access session state if it is available
            if (Context.Handler is IRequiresSessionState || Context.Handler is IReadOnlySessionState)
            {
                //If we are authenticated AND we dont have a session here.. redirect to login page.
                HttpCookie authenticationCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
                if (authenticationCookie != null)
                {
                    FormsAuthenticationTicket authenticationTicket = FormsAuthentication.Decrypt(authenticationCookie.Value);
                    if (!authenticationTicket.Expired)
                    {
                        if (Session["UniqueUserId"] == null)
                        {
                            //This means for some reason the session expired before the authentication ticket. Force a login.
                            FormsAuthentication.SignOut();
                            Response.Redirect(FormsAuthentication.LoginUrl, true);
                            return;
                        }
                    }
                }
            }
        }
    }
}
