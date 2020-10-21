using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TResourceVersionStringSpeaker
    {
        public int ResourceVersionId { get; set; }
        public int StringId { get; set; }
        public int CharacterResourceId { get; set; }
        public bool IsVoeligible { get; set; }
        public bool IsVoreRecord { get; set; }
        public DateTime VorequestOnUtc { get; set; }
        public int VorequestResourceVersionId { get; set; }

        public virtual TResource CharacterResource { get; set; }
        public virtual TResourceVersionString TResourceVersionString { get; set; }
    }
}
