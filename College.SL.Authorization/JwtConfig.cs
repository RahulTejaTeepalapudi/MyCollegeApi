using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.SL.Authorization
{
    public static class JwtConfig
    {
        public static string Secret { get; set; } = "1a13faeb7d22432f808bacfea5c0f8fc58c9ff6ff14b46108df06960e4a3c1f9";
        public static string Audience { get; set; } = "my-college-api-audience";
        public static string Issuer { get; set; } = "my-college-api-issuer";
    }
}
