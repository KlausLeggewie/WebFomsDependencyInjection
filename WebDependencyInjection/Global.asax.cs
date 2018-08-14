using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Unity;
using WebDependencyInjection.Repositories;

namespace WebDependencyInjection
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = this.AddUnity();
           
            container.RegisterType<IProductRepository, ProductRepository>();
        }
    }
}