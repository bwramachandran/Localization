using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TRecordingType
    {
        public TRecordingType()
        {
            TResourceVersionString = new HashSet<TResourceVersionString>();
        }

        public int RecordingTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual ICollection<TResourceVersionString> TResourceVersionString { get; set; }
    }
}
