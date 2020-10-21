using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVoscriptGenerationSession
    {
        public TVoscriptGenerationSession()
        {
            TCloneVoscriptGenerationSession = new HashSet<TCloneVoscriptGenerationSession>();
            TVoscriptInstance = new HashSet<TVoscriptInstance>();
        }

        public int VoscriptGenerationSessionId { get; set; }
        public int LanguageId { get; set; }
        public DateTime GenerationAnchorUtc { get; set; }
        public string GenerationComment { get; set; }
        public bool Unprinted { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string CreatedBy { get; set; }
        public int? TranslationPartnerId { get; set; }

        public virtual TTranslationPartner TranslationPartner { get; set; }
        public virtual ICollection<TCloneVoscriptGenerationSession> TCloneVoscriptGenerationSession { get; set; }
        public virtual ICollection<TVoscriptInstance> TVoscriptInstance { get; set; }
    }
}
