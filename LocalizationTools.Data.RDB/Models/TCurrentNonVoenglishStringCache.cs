using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCurrentNonVoenglishStringCache
    {
        public int StringId { get; set; }
        public int FriendlyStringId { get; set; }
        public int LocalizedVersionId { get; set; }
        public int MaxLvid { get; set; }
        public int ResourceVersionId { get; set; }
        public string Text { get; set; }
        public string Vocomment { get; set; }
        public int BranchId { get; set; }
        public int BranchPriority { get; set; }
        public int MinPriority { get; set; }
    }
}
