﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mySite.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            ContainerConfig.Configure();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
