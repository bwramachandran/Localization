using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TStringRemovalType
    {
        public int RemovalTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
