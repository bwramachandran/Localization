using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TWritingWorkflowState
    {
        public TWritingWorkflowState()
        {
            TResourceVersion = new HashSet<TResourceVersion>();
        }

        public int WritingWorkflowStateId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TResourceVersion> TResourceVersion { get; set; }
    }
}
