using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TStringHistory
    {
        public int StringHistoryId { get; set; }
        public int StringId { get; set; }
        public string StringUniqueId { get; set; }
        public int FriendlyStringId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual TString String { get; set; }
    }
}
