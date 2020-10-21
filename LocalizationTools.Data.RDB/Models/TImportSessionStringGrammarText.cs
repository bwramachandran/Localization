using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TImportSessionStringGrammarText
    {
        public int ImportSessionStringId { get; set; }
        public int GrammarNounGenderId { get; set; }
        public int GrammarNounNumberId { get; set; }
        public string Text { get; set; }
        public int ModifierPositionId { get; set; }
        public bool BeginsWithVowelSound { get; set; }
        public bool IsTranslationModified { get; set; }
        public int LocalizedVersionId { get; set; }

        public virtual TImportSessionString ImportSessionString { get; set; }
    }
}
