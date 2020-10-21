using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TTranslationPartner
    {
        public TTranslationPartner()
        {
            TExportSession = new HashSet<TExportSession>();
            TImportSessionStageString = new HashSet<TImportSessionStageString>();
            TImportSessionString = new HashSet<TImportSessionString>();
            TStringCloneTriageProfile = new HashSet<TStringCloneTriageProfile>();
            TVoscriptGenerationSession = new HashSet<TVoscriptGenerationSession>();
        }

        public int TranslationPartnerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TExportSession> TExportSession { get; set; }
        public virtual ICollection<TImportSessionStageString> TImportSessionStageString { get; set; }
        public virtual ICollection<TImportSessionString> TImportSessionString { get; set; }
        public virtual ICollection<TStringCloneTriageProfile> TStringCloneTriageProfile { get; set; }
        public virtual ICollection<TVoscriptGenerationSession> TVoscriptGenerationSession { get; set; }
    }
}
