using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCastingRole
    {
        public TCastingRole()
        {
            TCharacterCasting = new HashSet<TCharacterCasting>();
        }

        public int CastingRoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TCharacterCasting> TCharacterCasting { get; set; }
    }
}
