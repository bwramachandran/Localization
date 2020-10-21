using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TImportRecallHistory
    {
        public TImportRecallHistory()
        {
            TImportSessionStringRecallHistory = new HashSet<TImportSessionStringRecallHistory>();
        }

        public int ImportRecallHistoryId { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual ICollection<TImportSessionStringRecallHistory> TImportSessionStringRecallHistory { get; set; }
    }
}
