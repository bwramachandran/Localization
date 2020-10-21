using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TStringImportCache
    {
        public int StringId { get; set; }
        public int FriendlyStringId { get; set; }
        public int LocalizedVersionId { get; set; }
        public int ResourceVersionId { get; set; }
        public string Text { get; set; }
        public int VariantId { get; set; }
        public int PlayerVariantId { get; set; }
        public string Vocomment { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public int BranchPriority { get; set; }
        public int? MinPriority { get; set; }
        public int VoscriptId { get; set; }
        public int LanguageId { get; set; }
    }
}
