using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CacheDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            string s = "data source=VCG-VIKRAMSA;initial catalog=Hr;integrated security=True;";
            SqlCacheDependencyAdmin.EnableNotifications(s);
            SqlCacheDependencyAdmin.EnableTableForNotifications(s, "Employees");

        }
    }
}
