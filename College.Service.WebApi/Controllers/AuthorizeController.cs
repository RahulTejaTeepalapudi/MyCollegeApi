using College.SL.Authorization;
using College.SL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace College.Service.WebApi.Controllers
{
    public class AuthorizeController : ApiController
    {
        private readonly AuthService _authService = new AuthService();
        private readonly JwtTokenHelper _tokenHelper = new JwtTokenHelper();

        //public List<AppDto> Get()
        //{
        //    return _authService.GetAuthorizedApps()
        //            .Select(i => new AppDto
        //            {
        //                Name = i.Name,
        //                TokenExpiration = i.TokenExpiration
        //            }).ToList();
        //}

        /// <summary>
        /// Issues the Token verifying request details in Authorized apps from database
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Jwt Token</returns>
        public IHttpActionResult Post(AuthorizeRequestDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            //var authApp = _authService.GetAuthorizedApps()
            //    .FirstOrDefault(i => i.AppToken == request.AppToken
            //                         && i.AppSecret == request.AppSecret
            //                         && DateTime.UtcNow < i.TokenExpiration);
            var authApp = _authService.GetAuthorizedApps()
                .FirstOrDefault(i => i.AppToken == request.AppToken
                                     && i.AppSecret == request.AppSecret);

            if (authApp == null) return Unauthorized();

            var token = _tokenHelper.CreateToken(authApp);
            return Ok(token);
        }
    }
}