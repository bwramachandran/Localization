using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TResourceVersionString
    {
        public TResourceVersionString()
        {
            InverseTResourceVersionStringNavigation = new HashSet<TResourceVersionString>();
            TExportSessionString = new HashSet<TExportSessionString>();
            TResourceVersionStringSpeaker = new HashSet<TResourceVersionStringSpeaker>();
            TVoscriptInstanceString = new HashSet<TVoscriptInstanceString>();
        }

        public int ResourceVersionId { get; set; }
        public int StringId { get; set; }
        public string Text { get; set; }
        public bool IsMajorEdit { get; set; }
        public int StringTypeId { get; set; }
        public bool IsTextModified { get; set; }
        public int? ListenerCharacterResourceId { get; set; }
        public bool IsLocalizationReady { get; set; }
        public bool IsVoready { get; set; }
        public bool IsVoeligible { get; set; }
        public int RecordingTypeId { get; set; }
        public bool IsTranslationEligible { get; set; }
        public int WordCount { get; set; }
        public int MaxCharacterLength { get; set; }
        public int TimingRestriction { get; set; }
        public bool IsBlank { get; set; }
        public bool IsSuspect { get; set; }
        public int ActorVolumeStringVoenumId { get; set; }
        public int ActorIntensityStringVoenumId { get; set; }
        public int LocalizedVersionId { get; set; }
        public DateTime MinorEditOnUtc { get; set; }
        public DateTime MajorEditOnUtc { get; set; }
        public int MinorEditResourceVersionId { get; set; }
        public int MajorEditResourceVersionId { get; set; }
        public int? PreviousResourceVersionId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual TStringVoenum ActorIntensityStringVoenum { get; set; }
        public virtual TStringVoenum ActorVolumeStringVoenum { get; set; }
        public virtual TRecordingType RecordingType { get; set; }
        public virtual TResourceVersion ResourceVersion { get; set; }
        public virtual TString String { get; set; }
        public virtual TStringType StringType { get; set; }
        public virtual TResourceVersionString TResourceVersionStringNavigation { get; set; }
        public virtual TResourceVersionStringComment TResourceVersionStringComment { get; set; }
        public virtual TResourceVersionStringGrammar TResourceVersionStringGrammar { get; set; }
        public virtual ICollection<TResourceVersionString> InverseTResourceVersionStringNavigation { get; set; }
        public virtual ICollection<TExportSessionString> TExportSessionString { get; set; }
        public virtual ICollection<TResourceVersionStringSpeaker> TResourceVersionStringSpeaker { get; set; }
        public virtual ICollection<TVoscriptInstanceString> TVoscriptInstanceString { get; set; }
    }
}
