using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PostalCode
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }

    public class Global : System.Web.HttpApplication
    {
        public static readonly DateTime DATEMIN = DateTime.Parse("1999/12/31 23:59:59");
        public static readonly DateTime DATEMAX = DateTime.Parse("2099/12/31 00:00:00");
        public static readonly string NOTSET = "Not Set";
        public static readonly List<string> DATALIST = new List<string>
        {
            "Data1",
            "Data2",
            "Data3"
        };
    }
}
