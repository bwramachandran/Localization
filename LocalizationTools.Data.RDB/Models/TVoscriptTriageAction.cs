using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVoscriptTriageAction
    {
        public TVoscriptTriageAction()
        {
            TVoscriptInstanceStringTriage = new HashSet<TVoscriptInstanceStringTriage>();
        }

        public int VoscriptTriageActionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TVoscriptInstanceStringTriage> TVoscriptInstanceStringTriage { get; set; }
    }
}
