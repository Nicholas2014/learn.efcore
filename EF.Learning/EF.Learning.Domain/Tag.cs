using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Learning.Domain
{
    public class Tag: ModelBase
    {
        public string Name { get; set; }

        public ICollection<ApplicationTag> ApplicationTags { get; set; }
    }
}
