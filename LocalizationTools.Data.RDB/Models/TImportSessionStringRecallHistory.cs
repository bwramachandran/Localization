using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TImportSessionStringRecallHistory
    {
        public int ImportSessionStringRecallHistoryId { get; set; }
        public int ImportRecallHistoryId { get; set; }
        public int ImportSessionStringId { get; set; }
        public int? NextImportSessionStringId { get; set; }

        public virtual TImportRecallHistory ImportRecallHistory { get; set; }
        public virtual TImportSessionString ImportSessionString { get; set; }
        public virtual TImportSessionString NextImportSessionString { get; set; }
    }
}
