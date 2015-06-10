using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Angular4DotNet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Registration",
            //    url: "Registration/{*catchall}",
            //    defaults: new { controller = "Registration", action = "Index" }
            //);
            //routes.MapRoute(
            //    name: "Registration Courses",
            //    url: "Registration/Courses",
            //    defaults: new { controller = "Registration", action = "Index" }
            //);

            //routes.MapRoute(
            //    name: "Registration Instructors",
            //    url: "Registration/Instructors",
            //    defaults: new { controller = "Registration", action = "Index" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Registration", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}