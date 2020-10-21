using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VScopeByWritingWorkflow
    {
        public DateTime DateUtc { get; set; }
        public string DataDirectory { get; set; }
        public string Build { get; set; }
        public string ScopeTag { get; set; }
        public string ScopeSubTag { get; set; }
        public int? InWritingWordCount { get; set; }
        public int? WritingCompleteWordCount { get; set; }
        public int? EditingCompleteWordCount { get; set; }
        public int? RevisionsCompleteWordCount { get; set; }
        public int? LockedForVowordCount { get; set; }
        public int? TotalWordCount { get; set; }
    }
}
