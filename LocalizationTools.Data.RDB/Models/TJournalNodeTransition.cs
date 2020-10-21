using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TJournalNodeTransition
    {
        public int JournalNodeTransitionId { get; set; }
        public int ResourceVersionId { get; set; }
        public int? ParentNodeId { get; set; }
        public int ChildNodeId { get; set; }

        public virtual TJournalNode TJournalNode { get; set; }
        public virtual TJournalNode TJournalNodeNavigation { get; set; }
    }
}
