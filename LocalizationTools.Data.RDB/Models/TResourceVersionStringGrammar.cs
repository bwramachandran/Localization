using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TResourceVersionStringGrammar
    {
        public int ResourceVersionId { get; set; }
        public int StringId { get; set; }
        public int WordClassId { get; set; }
        public int PhraseTemplateId { get; set; }
        public int PhraseElementId { get; set; }
        public int ModifierPositionId { get; set; }

        public virtual TResourceVersionString TResourceVersionString { get; set; }
    }
}
