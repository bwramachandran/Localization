using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VHighLevelExportProgressByConversationLines
    {
        public DateTime DateUtc { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public int TotalStringCount { get; set; }
        public int ShipStringCount { get; set; }
        public int ReadyForTranslationStringCount { get; set; }
        public int TranslationPartnerId { get; set; }
        public string TranslationPartnerName { get; set; }
        public int StringExportLines { get; set; }
        public int ReExportedLines { get; set; }
        public int DeletedExportStringLines { get; set; }
        public int LanguageId { get; set; }
        public string LanguageTag { get; set; }
        public int HaveCurrentTranslationStringCount { get; set; }
    }
}
