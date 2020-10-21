using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCharacterCasting
    {
        public int ResourceVersionId { get; set; }
        public int VoiceResourceId { get; set; }
        public int CastingRoleId { get; set; }
        public int CurrentCastingActorId { get; set; }
        public string Comments { get; set; }
        public int Color { get; set; }

        public virtual TCastingRole CastingRole { get; set; }
        public virtual TCharacterCastingActor CurrentCastingActor { get; set; }
        public virtual TResourceVersion ResourceVersion { get; set; }
        public virtual TResource VoiceResource { get; set; }
    }
}
