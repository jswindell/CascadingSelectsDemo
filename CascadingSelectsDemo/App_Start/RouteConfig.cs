using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CascadingSelectsDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Developer Consoles",
                url: "developer/{developer}/consoles",
                defaults: new { controller = "Developer", action = "Consoles" }
            );

            routes.MapRoute(
                name: "Game Systems",
                url: "gamesystem/{developer}/{console}/games",
                defaults: new { controller = "GameSystem", action = "Games", developer="", console="" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
