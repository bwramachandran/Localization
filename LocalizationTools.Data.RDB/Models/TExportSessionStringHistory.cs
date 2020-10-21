using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TExportSessionStringHistory
    {
        public int ExportSessionStringHistoryId { get; set; }
        public int ExportSessionStringId { get; set; }
        public DateTime? OldCompareDate { get; set; }
        public DateTime NewCompareDate { get; set; }
        public int ExportSessionStringOperationId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string AuditComment { get; set; }

        public virtual TExportSessionString ExportSessionString { get; set; }
        public virtual TExportSessionStringOperation ExportSessionStringOperation { get; set; }
    }
}
