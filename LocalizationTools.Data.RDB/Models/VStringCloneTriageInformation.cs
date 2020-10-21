using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VStringCloneTriageInformation
    {
        public int StringCloneTriageId { get; set; }
        public int? SourceStringId { get; set; }
        public int? TargetStringId { get; set; }
        public int BranchId { get; set; }
        public int? TranslationPartnerId { get; set; }
        public DateTime TriagedOnUtc { get; set; }
        public bool Approved { get; set; }
        public bool Ignored { get; set; }
    }
}
