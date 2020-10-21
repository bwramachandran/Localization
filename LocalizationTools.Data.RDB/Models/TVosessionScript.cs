using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVosessionScript
    {
        public int VosessionScriptId { get; set; }
        public int VosessionId { get; set; }
        public Guid ScriptId { get; set; }
        public string Status { get; set; }
        public int? VoscriptInstanceId { get; set; }
        public string CustomScriptName { get; set; }
        public int LinesRecorded { get; set; }
        public string InternalNotes { get; set; }
        public string ChecklistNotes { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string CreatedBy { get; set; }

        public virtual TVoscriptInstance VoscriptInstance { get; set; }
        public virtual TVosession Vosession { get; set; }
    }
}
