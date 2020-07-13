using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoard.Core.Entities
{
    public class Job: BaseEntity
    {
        public string JobTitle { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpiresAt { get; set; }

    }
}
