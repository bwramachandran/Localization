using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TReducedScriptsCache
    {
        public string ParentResourceGuid { get; set; }
        public string VoiceResourceGuid { get; set; }
        public int VoscriptId { get; set; }
        public int BranchId { get; set; }
        public int BranchPriority { get; set; }
        public string ParentResourceName { get; set; }
        public string VoiceResourceName { get; set; }
        public bool IsPrinted { get; set; }
        public bool HasAprintedVersion { get; set; }
    }
}
