using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TModule
    {
        public TModule()
        {
            TResourceVersion = new HashSet<TResourceVersion>();
        }

        public int ModuleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TResourceVersion> TResourceVersion { get; set; }
    }
}
