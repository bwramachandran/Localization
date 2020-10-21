using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TParaphraseCategoryType
    {
        public TParaphraseCategoryType()
        {
            TParaphraseCategory = new HashSet<TParaphraseCategory>();
        }

        public int ParaphraseCategoryTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TParaphraseCategory> TParaphraseCategory { get; set; }
    }
}
