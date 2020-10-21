using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVostringData
    {
        public int VostringDataId { get; set; }
        public bool Active { get; set; }
        public int BranchId { get; set; }
        public int StringId { get; set; }
        public string VoproductionComment { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string CreatedBy { get; set; }
    }
}
