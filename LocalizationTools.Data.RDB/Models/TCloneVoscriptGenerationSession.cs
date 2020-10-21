using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCloneVoscriptGenerationSession
    {
        public int StringCloneEventId { get; set; }
        public int LanguageId { get; set; }
        public bool CloneStringWasVoeligible { get; set; }
        public int? VoscriptGenerationSessionId { get; set; }

        public virtual TStringCloneEvent StringCloneEvent { get; set; }
        public virtual TVoscriptGenerationSession VoscriptGenerationSession { get; set; }
    }
}
