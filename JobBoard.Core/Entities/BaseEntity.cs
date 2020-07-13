using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoard.Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; private set; }
    }
}
