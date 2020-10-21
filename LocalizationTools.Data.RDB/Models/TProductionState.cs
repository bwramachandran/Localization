using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TProductionState
    {
        public TProductionState()
        {
            TResourceVersion = new HashSet<TResourceVersion>();
        }

        public int ProductionStateId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TResourceVersion> TResourceVersion { get; set; }
    }
}
