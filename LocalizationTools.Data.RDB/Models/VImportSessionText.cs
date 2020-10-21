using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VImportSessionText
    {
        public int ImportSessionStringId { get; set; }
        public int BranchId { get; set; }
        public int LanguageId { get; set; }
        public int VariantId { get; set; }
        public int StringId { get; set; }
        public int FriendlyStringId { get; set; }
        public string Status { get; set; }
        public string Text { get; set; }
        public string PhoneticProcessingText { get; set; }
        public int LocalizedVersionId { get; set; }
    }
}
