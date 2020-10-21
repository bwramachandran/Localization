using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TString
    {
        public TString()
        {
            TJournalNode = new HashSet<TJournalNode>();
            TResourceVersionString = new HashSet<TResourceVersionString>();
            TStringCloneEventCloneString = new HashSet<TStringCloneEvent>();
            TStringCloneEventSourceString = new HashSet<TStringCloneEvent>();
            TStringHistory = new HashSet<TStringHistory>();
        }

        public int StringId { get; set; }
        public string StringUniqueId { get; set; }
        public int FriendlyStringId { get; set; }
        public bool IsPlaceholder { get; set; }
        public string SourceStringUniqueId { get; set; }

        public virtual ICollection<TJournalNode> TJournalNode { get; set; }
        public virtual ICollection<TResourceVersionString> TResourceVersionString { get; set; }
        public virtual ICollection<TStringCloneEvent> TStringCloneEventCloneString { get; set; }
        public virtual ICollection<TStringCloneEvent> TStringCloneEventSourceString { get; set; }
        public virtual ICollection<TStringHistory> TStringHistory { get; set; }
    }
}
