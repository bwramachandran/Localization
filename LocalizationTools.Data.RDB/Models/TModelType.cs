using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TModelType
    {
        public TModelType()
        {
            TResourceVersion = new HashSet<TResourceVersion>();
        }

        public int ModelTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TResourceVersion> TResourceVersion { get; set; }
    }
}
