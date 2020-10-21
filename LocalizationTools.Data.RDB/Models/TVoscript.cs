using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVoscript
    {
        public TVoscript()
        {
            TVoprepInstance = new HashSet<TVoprepInstance>();
            TVoscriptInstance = new HashSet<TVoscriptInstance>();
        }

        public int VoscriptId { get; set; }
        public int BranchId { get; set; }
        public int ParentResourceId { get; set; }
        public int VoiceResourceId { get; set; }
        public bool IsPlayer { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<TVoprepInstance> TVoprepInstance { get; set; }
        public virtual ICollection<TVoscriptInstance> TVoscriptInstance { get; set; }
    }
}
