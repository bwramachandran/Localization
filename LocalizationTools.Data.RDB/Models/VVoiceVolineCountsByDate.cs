using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VVoiceVolineCountsByDate
    {
        public DateTime DateUtc { get; set; }
        public string Voice { get; set; }
        public string IsPlayer { get; set; }
        public int? VolineCount { get; set; }
    }
}
