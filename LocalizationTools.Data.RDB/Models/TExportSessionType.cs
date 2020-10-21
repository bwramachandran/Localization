using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TExportSessionType
    {
        public TExportSessionType()
        {
            TExportSession = new HashSet<TExportSession>();
        }

        public int ExportSessionTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TExportSession> TExportSession { get; set; }
    }
}
