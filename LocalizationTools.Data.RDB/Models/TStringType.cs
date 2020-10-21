using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TStringType
    {
        public TStringType()
        {
            TResourceVersionString = new HashSet<TResourceVersionString>();
        }

        public int StringTypeId { get; set; }
        public Guid ProjectUniqueId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TResourceVersionString> TResourceVersionString { get; set; }
    }
}
