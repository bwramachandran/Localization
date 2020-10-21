using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVoscriptCache
    {
        public int BranchId { get; set; }
        public int StringId { get; set; }
        public int VoscriptId { get; set; }
        public int LanguageId { get; set; }
        public int VariantId { get; set; }
        public int ResourceVersionId { get; set; }
        public int? VoiceResourceId { get; set; }
        public bool IsVoready { get; set; }
        public bool RequiresRecording { get; set; }
        public bool PreviouslyRecorded { get; set; }
        public int LocalizedVersionId { get; set; }
        public bool ToKeep { get; set; }
        public string ParentResourceUniqueId { get; set; }
        public string VoiceResourceUniqueId { get; set; }
        public DateTime? CompareDate { get; set; }
        public DateTime? RecordingRequestedOn { get; set; }
        public int? VoscriptInstanceId { get; set; }
        public int? MaxVoscriptInstanceId { get; set; }
        public bool? HasAprintedVersion { get; set; }
        public string VofileName { get; set; }
        public int? BranchPriority { get; set; }
        public int? MinBranchPriority { get; set; }
        public DateTime? CacheUpdateDate { get; set; }
    }
}
