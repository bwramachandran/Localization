using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TImportSession
    {
        public TImportSession()
        {
            TImportSessionString = new HashSet<TImportSessionString>();
        }

        public int ImportSessionId { get; set; }
        public bool Recalled { get; set; }
        public DateTime ImportedOnUtc { get; set; }
        public string ImportedBy { get; set; }
        public string Comment { get; set; }
        public DateTime? ImportedIntoGameOnUtc { get; set; }
        public string GameChangelistId { get; set; }

        public virtual ICollection<TImportSessionString> TImportSessionString { get; set; }
    }
}
