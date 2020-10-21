using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TDataImportSession
    {
        public TDataImportSession()
        {
            TGrammarEnumeration = new HashSet<TGrammarEnumeration>();
            TResourceVersion = new HashSet<TResourceVersion>();
        }

        public int DataImportSessionId { get; set; }
        public string AppVersion { get; set; }
        public string Host { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual ICollection<TGrammarEnumeration> TGrammarEnumeration { get; set; }
        public virtual ICollection<TResourceVersion> TResourceVersion { get; set; }
    }
}
