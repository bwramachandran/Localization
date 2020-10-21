using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VLocalizationImportProgressByWords
    {
        public DateTime DateUtc { get; set; }
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public int TotalWordCount { get; set; }
        public int ShipWordCount { get; set; }
        public int EligibleForTranslationWordCount { get; set; }
        public int ReadyForTranslationWordCount { get; set; }
        public int TranslationPartnerId { get; set; }
        public string TranslationPartnerName { get; set; }
        public int StringExportWords { get; set; }
        public int LanguageId { get; set; }
        public string LanguageTag { get; set; }
        public int HaveCurrentTranslationMasculineEnglishWordCount { get; set; }
        public int HaveCurrentTranslationMasculineTranslatedWordCount { get; set; }
        public int HaveCurrentTranslationUniqueFeminineEnglishWordCount { get; set; }
        public int HaveCurrentTranslationUniqueFeminineTranslatedWordCount { get; set; }
    }
}
