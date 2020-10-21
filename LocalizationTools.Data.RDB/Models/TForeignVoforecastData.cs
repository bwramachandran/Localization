using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TForeignVoforecastData
    {
        public int ForeignVoforecastDataId { get; set; }
        public Guid SessionId { get; set; }
        public bool IsCurrent { get; set; }
        public int StringId { get; set; }
        public int FriendlyStringId { get; set; }
        public int VoscriptId { get; set; }
        public string Voice { get; set; }
        public string ScriptResource { get; set; }
        public string ScopeTag { get; set; }
        public string ScopeSubTag { get; set; }
        public bool RequiresEnglishRecording { get; set; }
        public DateTime? LastEnglishPrintedOnUtc { get; set; }
        public DateTime? LastEnglishReceivedOn { get; set; }
        public bool RequiresTranslation { get; set; }
        public DateTime? LastSentForTranslationOnUtc { get; set; }
        public int LanguageId { get; set; }
        public string LanguageTag { get; set; }
        public int VariantId { get; set; }
        public DateTime? LastImportedOnUtc { get; set; }
        public bool? RequiresForeignRecording { get; set; }
        public DateTime? LastForeignPrintedOnUtc { get; set; }
        public string WritingWorkflowState { get; set; }
        public string ProductionState { get; set; }
        public bool TranslationEligible { get; set; }
        public bool Voeligible { get; set; }
        public bool TranslationReady { get; set; }
        public bool Voready { get; set; }
        public string EnglishText { get; set; }
        public string TranslatedText { get; set; }
        public string Vocomment { get; set; }
        public bool ExportedAsClone { get; set; }
        public bool IsClone { get; set; }
        public int TimingRestriction { get; set; }
    }
}
