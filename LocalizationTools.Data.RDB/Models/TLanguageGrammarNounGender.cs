using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TLanguageGrammarNounGender
    {
        public int LanguageId { get; set; }
        public int GrammarNounGenderId { get; set; }

        public virtual TLanguage Language { get; set; }
    }
}
