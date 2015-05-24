using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPIExp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Users",
                routeTemplate: "users/{userid}",
                defaults: new { controller = "user", userid = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Orders",
                routeTemplate: "users/{userid}/orders/{id}",
                defaults: new { controller = "order", id = RouteParameter.Optional }
            );
        }
    }
}
