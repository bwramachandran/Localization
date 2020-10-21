using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TLanguage
    {
        public TLanguage()
        {
            TLanguageGrammarNounGender = new HashSet<TLanguageGrammarNounGender>();
            TLanguageGrammarNounNumber = new HashSet<TLanguageGrammarNounNumber>();
            TLanguageTag = new HashSet<TLanguageTag>();
            TLanguageVariant = new HashSet<TLanguageVariant>();
        }

        public int LanguageId { get; set; }
        public string Name { get; set; }
        public bool MasterLanguage { get; set; }
        public string ProjectMetadata { get; set; }

        public virtual TLanguageGrammar TLanguageGrammar { get; set; }
        public virtual ICollection<TLanguageGrammarNounGender> TLanguageGrammarNounGender { get; set; }
        public virtual ICollection<TLanguageGrammarNounNumber> TLanguageGrammarNounNumber { get; set; }
        public virtual ICollection<TLanguageTag> TLanguageTag { get; set; }
        public virtual ICollection<TLanguageVariant> TLanguageVariant { get; set; }
    }
}
