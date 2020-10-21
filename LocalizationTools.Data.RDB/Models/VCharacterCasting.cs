using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VCharacterCasting
    {
        public int ResourceVersionId { get; set; }
        public int VoiceResourceId { get; set; }
        public string Role { get; set; }
        public string CurrentActor { get; set; }
        public int CurrentCastingActorId { get; set; }
        public string Comments { get; set; }
        public int Color { get; set; }
        public string VoiceResourceGuid { get; set; }
    }
}
