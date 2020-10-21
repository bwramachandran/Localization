using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TResourceType
    {
        public TResourceType()
        {
            TResourceVersion = new HashSet<TResourceVersion>();
        }

        public int ResourceTypeId { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }

        public virtual ICollection<TResourceVersion> TResourceVersion { get; set; }
    }
}
