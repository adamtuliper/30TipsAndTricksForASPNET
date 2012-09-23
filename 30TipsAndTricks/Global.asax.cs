using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.Web;
using StackExchange.Profiling;
using _30TipsAndTricks.Cache;
using _30TipsAndTricks.Interfaces;
using _30TipsAndTricks.Repositories;

namespace _30TipsAndTricks
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_BeginRequest()
        {
            if (Request.IsLocal)
            {
                MiniProfiler.Start();
            }
        }

        protected void Application_EndRequest()
        {
            MiniProfiler.Stop();
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleTable.EnableOptimizations = true;
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            //*********************************
            //Autofac specific code
            var builder = new ContainerBuilder();
            builder.RegisterType<MemoryCacheProvider>().As<ICacheProvider>().InstancePerLifetimeScope();
            builder.RegisterType<StateRepository>().As<StateRepository>().InstancePerLifetimeScope();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //Register model binders (if you use them)
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //*********************************
            //ViewEngines.Engines.Clear();
            var webFormsViewEngine = ViewEngines.Engines.OfType<WebFormViewEngine>().FirstOrDefault();
            if (webFormsViewEngine != null)
            {
                ViewEngines.Engines.Remove(webFormsViewEngine);
            }
        }
    }
}