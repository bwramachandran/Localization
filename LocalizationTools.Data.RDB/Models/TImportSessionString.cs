using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TImportSessionString
    {
        public TImportSessionString()
        {
            InversePreviousImportSessionString = new HashSet<TImportSessionString>();
            TImportSessionStageString = new HashSet<TImportSessionStageString>();
            TImportSessionStringGrammarText = new HashSet<TImportSessionStringGrammarText>();
            TImportSessionStringRecallHistoryImportSessionString = new HashSet<TImportSessionStringRecallHistory>();
            TImportSessionStringRecallHistoryNextImportSessionString = new HashSet<TImportSessionStringRecallHistory>();
        }

        public int ImportSessionStringId { get; set; }
        public int BranchId { get; set; }
        public int LanguageId { get; set; }
        public int VariantId { get; set; }
        public int StringId { get; set; }
        public string Status { get; set; }
        public bool IsGrammarString { get; set; }
        public int TranslationPartnerId { get; set; }
        public bool ReRecord { get; set; }
        public DateTime VorequestOnUtc { get; set; }
        public int ImportSessionId { get; set; }
        public int? PreviousImportSessionStringId { get; set; }
        public int? SourceResourceVersionId { get; set; }
        public int? TranslationPartnerTrackingId { get; set; }
        public int? TranslationPartnerSourceTextWordCount { get; set; }
        public int? TranslationPartnerWordCount { get; set; }
        public bool IsClone { get; set; }
        public int WordCount { get; set; }
        public bool IsTranslationModified { get; set; }
        public bool IsPhoneticTextModified { get; set; }
        public int LocalizedVersionId { get; set; }

        public virtual TBranch Branch { get; set; }
        public virtual TImportSession ImportSession { get; set; }
        public virtual TImportSessionString PreviousImportSessionString { get; set; }
        public virtual TLanguageVariant TLanguageVariant { get; set; }
        public virtual TTranslationPartner TranslationPartner { get; set; }
        public virtual ICollection<TImportSessionString> InversePreviousImportSessionString { get; set; }
        public virtual ICollection<TImportSessionStageString> TImportSessionStageString { get; set; }
        public virtual ICollection<TImportSessionStringGrammarText> TImportSessionStringGrammarText { get; set; }
        public virtual ICollection<TImportSessionStringRecallHistory> TImportSessionStringRecallHistoryImportSessionString { get; set; }
        public virtual ICollection<TImportSessionStringRecallHistory> TImportSessionStringRecallHistoryNextImportSessionString { get; set; }
    }
}
