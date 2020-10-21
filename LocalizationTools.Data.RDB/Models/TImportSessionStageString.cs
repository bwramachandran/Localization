using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TImportSessionStageString
    {
        public TImportSessionStageString()
        {
            TImportSessionStageStringGrammarText = new HashSet<TImportSessionStageStringGrammarText>();
        }

        public int ImportSessionStageId { get; set; }
        public int BranchId { get; set; }
        public int LanguageId { get; set; }
        public int VariantId { get; set; }
        public int StringId { get; set; }
        public bool IsGrammarString { get; set; }
        public int TranslationPartnerId { get; set; }
        public string Text { get; set; }
        public bool ReRecord { get; set; }
        public int? SourceResourceVersionId { get; set; }
        public int? TranslationPartnerTrackingId { get; set; }
        public int? TranslationPartnerSourceTextWordCount { get; set; }
        public int? TranslationPartnerWordCount { get; set; }
        public string PhoneticProcessingText { get; set; }
        public int? PreviousImportSessionStringId { get; set; }
        public DateTime? VorequestOnUtc { get; set; }
        public bool? IsClone { get; set; }
        public int LocalizedVersionId { get; set; }

        public virtual TBranch Branch { get; set; }
        public virtual TImportSessionStage ImportSessionStage { get; set; }
        public virtual TImportSessionString PreviousImportSessionString { get; set; }
        public virtual TLanguageVariant TLanguageVariant { get; set; }
        public virtual TTranslationPartner TranslationPartner { get; set; }
        public virtual ICollection<TImportSessionStageStringGrammarText> TImportSessionStageStringGrammarText { get; set; }
    }
}
