﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
   public  abstract class EntityBase :IEntityBase
    {
        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual string? DelatedBy { get; set; }
        public virtual   string?  CreatedBy { get; set; }
        public virtual  string? ModifiedBy { get; set; }
        public virtual DateTime? CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? DelatedDate  { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public virtual  bool IsDelate { get; set; }
    }
}
