using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VPrintedStringTextVersions
    {
        public string Text { get; set; }
        public string FullName { get; set; }
        public int FriendlyStringId { get; set; }
        public bool IsUnPrinted { get; set; }
        public string Actor { get; set; }
        public DateTime SessionDate { get; set; }
    }
}
