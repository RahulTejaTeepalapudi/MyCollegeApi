using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.SL.DTOs
{
    public class AuthorizeRequestDto
    {
        //[Required]
        //[MinLength(32), MaxLength(32)]
        public string AppToken { get; set; }

        //[Required]
        //[MinLength(32), MaxLength(32)]
        public string AppSecret { get; set; }
    }
}
