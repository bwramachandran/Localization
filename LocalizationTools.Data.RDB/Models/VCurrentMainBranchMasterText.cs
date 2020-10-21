using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VCurrentMainBranchMasterText
    {
        public int BranchId { get; set; }
        public int FriendlyStringId { get; set; }
        public string Text { get; set; }
    }
}
