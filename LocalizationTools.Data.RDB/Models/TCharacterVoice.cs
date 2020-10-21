using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCharacterVoice
    {
        public int ResourceVersionId { get; set; }
        public int VoiceResourceId { get; set; }

        public virtual TCharacter ResourceVersion { get; set; }
        public virtual TResource VoiceResource { get; set; }
    }
}
