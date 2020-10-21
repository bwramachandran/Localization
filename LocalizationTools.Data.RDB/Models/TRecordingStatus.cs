using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TRecordingStatus
    {
        public string Name { get; set; }
        public int? RecordingStatusId { get; set; }
        public string Description { get; set; }
    }
}
