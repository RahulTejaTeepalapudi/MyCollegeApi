using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.SL.DTOs
{
    public class AuthorizedAppDto
    {
        public int AuthorizedAppId { get; set; }

        //[Required]
        //[StringLength(100)]
        public string Name { get; set; }

        //[Required]
        //[StringLength(32)]
        public string AppToken { get; set; }

        //[Required]
        //[StringLength(32)]
        public string AppSecret { get; set; }

        public DateTime TokenExpiration { get; set; }
    }
}
