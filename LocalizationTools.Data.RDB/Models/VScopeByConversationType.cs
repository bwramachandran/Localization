using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VScopeByConversationType
    {
        public DateTime DateUtc { get; set; }
        public string DataDirectory { get; set; }
        public string Build { get; set; }
        public string ScopeTag { get; set; }
        public string ScopeSubTag { get; set; }
        public int? TotalWordsBudgeted { get; set; }
        public int? TotalWordsActual { get; set; }
        public int? TotalWordsRemaining { get; set; }
        public int? TotalLinesActual { get; set; }
        public int? StagedWordsBudgeted { get; set; }
        public int? StagedWordsActual { get; set; }
        public int? StagedWordsRemaining { get; set; }
        public int? StagedLinesActual { get; set; }
        public int? AmbientWordsBudgeted { get; set; }
        public int? AmbientWordsActual { get; set; }
        public int? AmbientWordsRemaining { get; set; }
        public int? AmbientLinesActual { get; set; }
        public int? TotalNonVowordsActual { get; set; }
        public int? TotalNonVolinesActual { get; set; }
    }
}
