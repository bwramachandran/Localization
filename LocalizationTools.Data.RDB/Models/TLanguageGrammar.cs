using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TLanguageGrammar
    {
        public int LanguageId { get; set; }
        public bool InitialVowelDeclinesPreviousModifier { get; set; }
        public int CapitalizationStyleId { get; set; }

        public virtual TLanguage Language { get; set; }
    }
}
