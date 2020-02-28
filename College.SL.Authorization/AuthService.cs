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
                    Name = "App1",
                    AuthorizedAppId = 1,
                    AppSecret = "1a13faeb7d22432f808bacfea5c0f8fc58c9ff6ff14b46108df06960e4a3c1f9",
                    AppToken = "646487264816246234982749826487357",
                    TokenExpiration = DateTime.Today
                },
                new AuthorizedAppDto {
                    Name = "App2",
                    AuthorizedAppId = 2,
                    AppSecret = "23vsvdfdf323553k5b2kj3bk23bb23j5j234j23bj23b4kj2b323j23hb",
                    AppToken = "09899824102091249823749823845285734",
                    TokenExpiration = DateTime.Today
                },

            };
        }
    }
}
