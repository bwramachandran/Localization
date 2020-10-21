using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TActor
    {
        public TActor()
        {
            TCharacterCastingActor = new HashSet<TCharacterCastingActor>();
        }

        public int ActorId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TCharacterCastingActor> TCharacterCastingActor { get; set; }
    }
}
