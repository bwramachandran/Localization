using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TResourceHistory
    {
        public int ResourceHistoryId { get; set; }
        public int ResourceId { get; set; }
        public bool IsActive { get; set; }
        public string ResourceUniqueId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual TResource Resource { get; set; }
    }
}
