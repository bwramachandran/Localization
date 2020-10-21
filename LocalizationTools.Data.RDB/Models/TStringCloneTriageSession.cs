using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TStringCloneTriageSession
    {
        public TStringCloneTriageSession()
        {
            TStringCloneTriage = new HashSet<TStringCloneTriage>();
        }

        public int StringCloneTriageSessionId { get; set; }
        public string TriagedBy { get; set; }
        public DateTime TriagedOnUtc { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<TStringCloneTriage> TStringCloneTriage { get; set; }
    }
}
