using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Learning.Domain
{
    public class Account: ModelBase
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string QQ { get; set; }

        public Application Application { get; set; }

    }
}
