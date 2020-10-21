using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TParaphraseCategory
    {
        public int ResourceVersionId { get; set; }
        public string Name { get; set; }
        public int ParaphraseCategoryTypeId { get; set; }

        public virtual TParaphraseCategoryType ParaphraseCategoryType { get; set; }
        public virtual TResourceVersion ResourceVersion { get; set; }
    }
}
