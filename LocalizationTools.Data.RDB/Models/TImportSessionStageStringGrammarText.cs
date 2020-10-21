using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TImportSessionStageStringGrammarText
    {
        public int BranchId { get; set; }
        public int LanguageId { get; set; }
        public int VariantId { get; set; }
        public int StringId { get; set; }
        public int ImportSessionStageId { get; set; }
        public int GrammarNounGenderId { get; set; }
        public int GrammarNounNumberId { get; set; }
        public string Text { get; set; }
        public int ModifierPositionId { get; set; }
        public bool BeginsWithVowelSound { get; set; }
        public bool? IsTranslationModified { get; set; }
        public int LocalizedVersionId { get; set; }

        public virtual TImportSessionStage ImportSessionStage { get; set; }
        public virtual TImportSessionStageString TImportSessionStageString { get; set; }
    }
}
