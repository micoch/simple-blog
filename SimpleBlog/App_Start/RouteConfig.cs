using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Controllers;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new [] {typeof(PostController).Namespace};

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("login", "login", new { controller = "Auth", action = "Login" }, namespaces);

            routes.MapRoute("home", "", new { controller = "Post", action = "Index" }, namespaces );
        }
    }
}
