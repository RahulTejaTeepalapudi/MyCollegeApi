using College.SL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.SL.Authorization
{
    public class AuthService
    {
        public IEnumerable<AuthorizedAppDto> GetAuthorizedApps()
        {
            return new List<AuthorizedAppDto>
            {
                new AuthorizedAppDto {
                    Name = "",
                    AuthorizedAppId =1,
                    AppSecret ="",
                    AppToken ="",
                    TokenExpiration = DateTime.Today
                }
            };
        }
    }
}
