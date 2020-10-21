using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TExportSession
    {
        public TExportSession()
        {
            TExportSessionString = new HashSet<TExportSessionString>();
        }

        public int ExportSessionId { get; set; }
        public int BranchId { get; set; }
        public int TranslationPartnerId { get; set; }
        public string Status { get; set; }
        public int ExportSessionTypeId { get; set; }
        public string RecalledBy { get; set; }
        public DateTime? RecalledOnUtc { get; set; }
        public string UniqueSessionId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual TBranch Branch { get; set; }
        public virtual TExportSessionType ExportSessionType { get; set; }
        public virtual TTranslationPartner TranslationPartner { get; set; }
        public virtual TExportSessionInfo TExportSessionInfo { get; set; }
        public virtual ICollection<TExportSessionString> TExportSessionString { get; set; }
    }
}
