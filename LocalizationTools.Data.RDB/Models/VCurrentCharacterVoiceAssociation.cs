using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VCurrentCharacterVoiceAssociation
    {
        public int CharacterResourceId { get; set; }
        public int CharacterResourceVersionId { get; set; }
        public int VoiceResourceId { get; set; }
        public int VoiceResourceVersionId { get; set; }
    }
}
