using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
using Owin;
using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using College.SL.Authorization;


namespace College.Service.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            /* Swagger Configuration */
            config.EnableSwagger(c => {
                c.SingleApiVersion("V1", "MyCollegeAPI");
                c.IncludeXmlComments($"{AppDomain.CurrentDomain.BaseDirectory}\\bin\\College.Service.WebApi.xml");
                }).EnableSwaggerUi();

            

            /* JwtValidationHandler */
            config.MessageHandlers.Add(new JwtValidationHandler());
        }

        
    }
}
