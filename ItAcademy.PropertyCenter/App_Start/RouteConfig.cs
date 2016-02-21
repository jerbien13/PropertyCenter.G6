using System.Web.Mvc;
using System.Web.Routing;

namespace ItAcademy.PropertyCenter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "home",
                url: "",
                defaults: new { controller = "Home", action = "Index" });

            routes.MapRoute(
                name: "about",
                url: "a",
                defaults: new { controller = "Home", action = "About" });

            routes.MapRoute(
                name: "contact",
                url: "c",
                defaults: new { controller = "Home", action = "Contact" });

            routes.MapRoute(
                name: "announcementList",
                url: "ai",
                defaults: new { controller = "Announcement", action = "Index" });


            routes.MapRoute(
                name: "announcementCreate",
                url: "ac",
                defaults: new { controller = "Announcement", action = "Create" });


            routes.MapRoute(
                name: "announcementEdit",
                url: "ae/{id}",
                defaults: new { controller = "Announcement", action = "Edit" },
                constraints:new{id="[0-9]+"});



            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
