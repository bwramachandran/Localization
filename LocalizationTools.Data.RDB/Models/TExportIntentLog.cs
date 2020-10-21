using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TExportIntentLog
    {
        public int ExportIntentLogId { get; set; }
        public int StringId { get; set; }
        public bool Exported { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}
