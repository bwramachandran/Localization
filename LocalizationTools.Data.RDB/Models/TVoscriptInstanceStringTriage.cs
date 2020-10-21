using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVoscriptInstanceStringTriage
    {
        public int VoscriptInstanceStringTriageId { get; set; }
        public int VoscriptInstanceStringId { get; set; }
        public bool Active { get; set; }
        public int VoscriptTriageActionId { get; set; }
        public DateTime CompareDate { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string CreatedBy { get; set; }

        public virtual TVoscriptInstanceString VoscriptInstanceString { get; set; }
        public virtual TVoscriptTriageAction VoscriptTriageAction { get; set; }
    }
}
