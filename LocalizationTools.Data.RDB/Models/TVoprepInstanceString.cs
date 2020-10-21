using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVoprepInstanceString
    {
        public int VoprepInstanceStringId { get; set; }
        public string PrepToken { get; set; }
        public int VoscriptId { get; set; }
        public int StringId { get; set; }
        public string VofileName { get; set; }
        public int VariantId { get; set; }
        public int? ImportSessionStringId { get; set; }

        public virtual TVoprepInstance TVoprepInstance { get; set; }
    }
}
