using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
using Owin;
using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using College.SL.Authorization;
using College.Service.WebApi.Filters;

namespace College.Service.WebApi
{
    public static class WebApiConfig
    {
        private static readonly IAppBuilder appBuilder;

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

            
            ConfigureJwt(appBuilder);

            /* JwtValidationHandler */
            config.MessageHandlers.Add(new JwtValidationHandler());
        }

        public static void ConfigureJwt(IAppBuilder app)
        {
            /* Jwt Configuration */
            app.UseJwtBearerAuthentication(
                new JwtBearerAuthenticationOptions
                {
                    AuthenticationMode = AuthenticationMode.Active,
                    AllowedAudiences = new[] { JwtConfig.Audience },
                    IssuerSecurityKeyProviders = new IIssuerSecurityKeyProvider[]
                    {
                        new SymmetricKeyIssuerSecurityKeyProvider(JwtConfig.Issuer, JwtConfig.Secret)
                    }
                });

        }
    }
}
