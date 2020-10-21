using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TStringCloneTriage
    {
        public int StringCloneTriageId { get; set; }
        public int StringCloneEventId { get; set; }
        public int StringCloneTriageProfileId { get; set; }
        public int StringCloneTriageSessionId { get; set; }
        public bool Approved { get; set; }
        public bool Ignored { get; set; }

        public virtual TStringCloneEvent StringCloneEvent { get; set; }
        public virtual TStringCloneTriageProfile StringCloneTriageProfile { get; set; }
        public virtual TStringCloneTriageSession StringCloneTriageSession { get; set; }
    }
}
