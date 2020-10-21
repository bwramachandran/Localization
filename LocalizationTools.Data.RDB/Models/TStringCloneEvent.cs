using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TStringCloneEvent
    {
        public TStringCloneEvent()
        {
            TCloneVoscriptGenerationSession = new HashSet<TCloneVoscriptGenerationSession>();
            TStringCloneTriage = new HashSet<TStringCloneTriage>();
        }

        public int StringCloneEventId { get; set; }
        public Guid EventGuid { get; set; }
        public string SourceStringUniqueId { get; set; }
        public int? SourceStringId { get; set; }
        public string CloneStringUniqueId { get; set; }
        public int? CloneStringId { get; set; }
        public string SourceResourceUniqueId { get; set; }
        public int SourceResourceId { get; set; }
        public int? SourceResourceVersionId { get; set; }
        public int CloneResourceVersionId { get; set; }
        public bool? IsMasterTextEqual { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? ProcessedOnUtc { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual TResourceVersion CloneResourceVersion { get; set; }
        public virtual TString CloneString { get; set; }
        public virtual TResource SourceResource { get; set; }
        public virtual TResourceVersion SourceResourceVersion { get; set; }
        public virtual TString SourceString { get; set; }
        public virtual ICollection<TCloneVoscriptGenerationSession> TCloneVoscriptGenerationSession { get; set; }
        public virtual ICollection<TStringCloneTriage> TStringCloneTriage { get; set; }
    }
}
