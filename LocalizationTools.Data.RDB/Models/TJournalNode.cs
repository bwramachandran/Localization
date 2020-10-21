using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TJournalNode
    {
        public TJournalNode()
        {
            TJournalNodeTransitionTJournalNode = new HashSet<TJournalNodeTransition>();
            TJournalNodeTransitionTJournalNodeNavigation = new HashSet<TJournalNodeTransition>();
        }

        public int ResourceVersionId { get; set; }
        public int NodeId { get; set; }
        public int TextStringId { get; set; }
        public string WritingComment { get; set; }

        public virtual TResourceVersion ResourceVersion { get; set; }
        public virtual TString TextString { get; set; }
        public virtual ICollection<TJournalNodeTransition> TJournalNodeTransitionTJournalNode { get; set; }
        public virtual ICollection<TJournalNodeTransition> TJournalNodeTransitionTJournalNodeNavigation { get; set; }
    }
}
