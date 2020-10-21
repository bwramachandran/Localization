using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TImportSessionStage
    {
        public TImportSessionStage()
        {
            TImportSessionStageString = new HashSet<TImportSessionStageString>();
            TImportSessionStageStringGrammarText = new HashSet<TImportSessionStageStringGrammarText>();
        }

        public int ImportSessionStageId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string CreatedBy { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<TImportSessionStageString> TImportSessionStageString { get; set; }
        public virtual ICollection<TImportSessionStageStringGrammarText> TImportSessionStageStringGrammarText { get; set; }
    }
}
