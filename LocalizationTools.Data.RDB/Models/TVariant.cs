using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVariant
    {
        public TVariant()
        {
            TLanguageVariant = new HashSet<TLanguageVariant>();
        }

        public int VariantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TLanguageVariant> TLanguageVariant { get; set; }
    }
}
