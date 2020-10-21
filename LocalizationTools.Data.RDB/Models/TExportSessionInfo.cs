using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TExportSessionInfo
    {
        public int ExportSessionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ForceExportReason { get; set; }

        public virtual TExportSession ExportSession { get; set; }
    }
}
