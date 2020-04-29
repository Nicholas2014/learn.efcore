using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Learning.Domain
{
    public class ModelBase : IPrimaryKey<int>
    {
        public ModelBase()
        {
            this.CreateDate = this.ModifyDate = DateTime.Now;
            this.IsDeleted = false;
        }

        public int Id { get; set; }
        public int Creator { get; set; }
        public DateTime CreateDate { get; set; }
        public int? Modifier { get; set; }
        public DateTime ModifyDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
