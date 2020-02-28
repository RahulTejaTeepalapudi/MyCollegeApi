using College.SL.Authorization;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
using Owin;
using Swashbuckle.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(College.Service.WebApi.App_Start.Startup))]
namespace College.Service.WebApi.App_Start
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            ConfigureJwt(app);
        }

        

        private void ConfigureJwt(IAppBuilder app)
        {
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