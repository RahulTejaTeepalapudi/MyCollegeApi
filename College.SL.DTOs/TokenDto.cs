using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.SL.DTOs
{
    public class TokenDto
    {
        public string Token { get; set; }
        public DateTime Expires { get; set; }
    }
}
