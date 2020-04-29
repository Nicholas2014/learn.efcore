using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Learning.Domain
{
    public class ApplicationTag
    {
        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
