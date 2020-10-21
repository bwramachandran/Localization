using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCharacterCastingActor
    {
        public TCharacterCastingActor()
        {
            TCharacterCasting = new HashSet<TCharacterCasting>();
        }

        public int CastingActorId { get; set; }
        public int ResourceId { get; set; }
        public int? ActorId { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual TActor Actor { get; set; }
        public virtual TResource Resource { get; set; }
        public virtual ICollection<TCharacterCasting> TCharacterCasting { get; set; }
    }
}
