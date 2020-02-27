using College.SL.DTOs;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;


namespace College.SL.Authorization
{
    public class JwtTokenHelper
    {
        public TokenDto CreateToken(AuthorizedAppDto authApp)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var issuedAt = DateTime.UtcNow;
            var expires = DateTime.UtcNow.AddDays(30);
            var claimsIdentity = new ClaimsIdentity(new GenericIdentity(authApp.Name), new[]
            {
                new Claim("appToken", authApp.AppToken, ClaimValueTypes.String),
            });

            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(JwtConfig.Secret));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            //create the token
            var token = tokenHandler.CreateJwtSecurityToken(
                JwtConfig.Issuer,
                JwtConfig.Audience,
                claimsIdentity,
                issuedAt,
                expires,
                signingCredentials: signingCredentials);

            return new TokenDto
            {
                Token = tokenHandler.WriteToken(token),
                Expires = expires,
            };
        }
    }
}
