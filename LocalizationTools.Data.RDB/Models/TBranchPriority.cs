using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TBranchPriority
    {
        public int PriorityId { get; set; }
        public int PriorityValue { get; set; }
        public string Name { get; set; }
    }
}
