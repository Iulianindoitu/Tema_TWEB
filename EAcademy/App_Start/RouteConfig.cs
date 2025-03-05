using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EAcademy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
               // Definesc o ruta costumizata pentru registrare
             routes.MapRoute(
             name: "Register",
/*"Account/LogIn"*/  url: "{controller}/{action}/{id}",
             defaults: new { controller = "LogIn", action = "Register" }
               );
          }
    }
}
