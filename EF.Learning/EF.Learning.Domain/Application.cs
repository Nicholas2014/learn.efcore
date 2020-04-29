using System;
using System.Collections.Generic;

namespace EF.Learning.Domain
{
    public class Application: ModelBase
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public ICollection<ApplicationTag> ApplicationTags { get; set; }
    }
}
