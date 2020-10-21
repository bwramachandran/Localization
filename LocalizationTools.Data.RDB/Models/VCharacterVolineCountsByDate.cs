using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VCharacterVolineCountsByDate
    {
        public DateTime DateUtc { get; set; }
        public string Character { get; set; }
        public int? VolineCount { get; set; }
    }
}
