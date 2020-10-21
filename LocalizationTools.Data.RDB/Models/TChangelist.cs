using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TChangelist
    {
        public TChangelist()
        {
            TGrammarEnumeration = new HashSet<TGrammarEnumeration>();
            TResourceVersion = new HashSet<TResourceVersion>();
        }

        public int ChangelistId { get; set; }
        public DateTime SubmittedOnUtc { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime DataExporterProcessedOnUtc { get; set; }
        public string ChangeId { get; set; }
        public string ChangeRangeStartId { get; set; }
        public string ChangeComment { get; set; }
        public string ContractProducerComment { get; set; }

        public virtual ICollection<TGrammarEnumeration> TGrammarEnumeration { get; set; }
        public virtual ICollection<TResourceVersion> TResourceVersion { get; set; }
    }
}
