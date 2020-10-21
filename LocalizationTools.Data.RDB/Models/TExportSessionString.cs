using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TExportSessionString
    {
        public TExportSessionString()
        {
            TExportSessionStringHistory = new HashSet<TExportSessionStringHistory>();
        }

        public int ExportSessionStringId { get; set; }
        public int ExportSessionId { get; set; }
        public int StringId { get; set; }
        public string Status { get; set; }
        public bool ForceExport { get; set; }
        public DateTime CompareDate { get; set; }
        public int ResourceVersionId { get; set; }
        public bool IsClone { get; set; }
        public int LastExportSessionStringOperationId { get; set; }
        public int? PreviousExportSessionStringId { get; set; }
        public string LastAuditComment { get; set; }

        public virtual TExportSession ExportSession { get; set; }
        public virtual TExportSessionStringOperation LastExportSessionStringOperation { get; set; }
        public virtual TResourceVersionString TResourceVersionString { get; set; }
        public virtual ICollection<TExportSessionStringHistory> TExportSessionStringHistory { get; set; }
    }
}
