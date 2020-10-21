using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TLanguageGrammarNounNumber
    {
        public int LanguageId { get; set; }
        public int GrammarNounNumberId { get; set; }

        public virtual TLanguage Language { get; set; }
    }
}
