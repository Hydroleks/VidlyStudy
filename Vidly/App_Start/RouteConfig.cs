using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
   
 /*
            //Customers route
            //before default rout
            //order of these routes must be most specific to most generic last.
            routes.MapRoute(
                "Customers",                   // name of route
                "Customers/Details/{id}",       // url pattern
                new { controller = "Customers", action = "Details" },  // default arguments - Details action must exist in Customers Controller
                new { id = @"\d{2}" });     // constraint through regular expressions.

            //custom route
            //before default rout
            //order of these routes must be most specific to most generic last.
            routes.MapRoute(
                "MoviesByReleasDate",                   // name of route
                "movies/released/{year}/{month}",       // url pattern
                new { controller = "Movies", action = "ByReleaseDate" },  // default arguments - ByReleaseDate action must exist in Movies Controller
                new { year = @"\d{4}", month = @"\d{2}" } );     // constraint through regular expressions.
            // new { year = @"2015|2016", month = @"\d{2}" } );     // constraint through regular expressions. year only 2015 or 2016
*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
