﻿using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebAPP
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            CultureInfo newCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            newCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            newCulture.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = newCulture;

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Database.SetInitializer<ApplicationDbContext>(null);

            ClientDataTypeModelValidatorProvider.ResourceClassKey = "ModelBinders";
            DefaultModelBinder.ResourceClassKey = "ModelBinders";
        }
    }
}