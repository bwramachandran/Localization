using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TLanguageVariant
    {
        public TLanguageVariant()
        {
            TImportSessionStageString = new HashSet<TImportSessionStageString>();
            TImportSessionString = new HashSet<TImportSessionString>();
        }

        public int LanguageId { get; set; }
        public int VariantId { get; set; }

        public virtual TLanguage Language { get; set; }
        public virtual TVariant Variant { get; set; }
        public virtual ICollection<TImportSessionStageString> TImportSessionStageString { get; set; }
        public virtual ICollection<TImportSessionString> TImportSessionString { get; set; }
    }
}
