using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VTranslationImportHistory
    {
        public DateTime? ImportedOnLocal { get; set; }
        public string ImportedBy { get; set; }
        public string ImportComment { get; set; }
        public string BranchName { get; set; }
        public string Language { get; set; }
        public int StringId { get; set; }
        public string Variant { get; set; }
        public bool IsTranslationRecalled { get; set; }
        public string Translation { get; set; }
        public int TranslationWordCount { get; set; }
        public bool IsTranslationModified { get; set; }
        public bool MarkedForReRecord { get; set; }
        public string PhoneticProcessingText { get; set; }
        public bool IsPhoneticTextModified { get; set; }
        public int? TranslationPartnerTrackingId { get; set; }
        public int TranslationCharacterCount { get; set; }
        public string ExportedText { get; set; }
        public string CurrentText { get; set; }
        public int CurrentMaxCharacterLength { get; set; }
    }
}
