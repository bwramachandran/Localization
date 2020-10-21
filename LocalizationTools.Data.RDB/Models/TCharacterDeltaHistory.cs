using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCharacterDeltaHistory
    {
        public int CharacterDeltaHistoryId { get; set; }
        public string User { get; set; }
        public string Comment { get; set; }
        public DateTime DeltaGeneratedOnUtc { get; set; }
    }
}
