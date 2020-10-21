using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TLanguageTag
    {
        public string Tag { get; set; }
        public int LanguageId { get; set; }
        public bool DefaultTag { get; set; }

        public virtual TLanguage Language { get; set; }
    }
}
