using System;
using System.Collections.Generic;

namespace QuickStart
{
    public partial class Posts
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public long BlogId { get; set; }

        public virtual Blogs Blog { get; set; }
    }
}
