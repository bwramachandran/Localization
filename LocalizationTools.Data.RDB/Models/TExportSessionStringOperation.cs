using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TExportSessionStringOperation
    {
        public TExportSessionStringOperation()
        {
            TExportSessionString = new HashSet<TExportSessionString>();
            TExportSessionStringHistory = new HashSet<TExportSessionStringHistory>();
        }

        public int ExportSessionStringOperationId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TExportSessionString> TExportSessionString { get; set; }
        public virtual ICollection<TExportSessionStringHistory> TExportSessionStringHistory { get; set; }
    }
}
