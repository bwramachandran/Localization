using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TBranch
    {
        public TBranch()
        {
            TExportSession = new HashSet<TExportSession>();
            TGrammarEnumeration = new HashSet<TGrammarEnumeration>();
            TImportSessionStageString = new HashSet<TImportSessionStageString>();
            TImportSessionString = new HashSet<TImportSessionString>();
            TResource = new HashSet<TResource>();
        }

        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int PriorityId { get; set; }

        public virtual ICollection<TExportSession> TExportSession { get; set; }
        public virtual ICollection<TGrammarEnumeration> TGrammarEnumeration { get; set; }
        public virtual ICollection<TImportSessionStageString> TImportSessionStageString { get; set; }
        public virtual ICollection<TImportSessionString> TImportSessionString { get; set; }
        public virtual ICollection<TResource> TResource { get; set; }
    }
}
