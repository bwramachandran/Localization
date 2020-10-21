using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCharacterSubCharacter
    {
        public int ResourceVersionId { get; set; }
        public int CharacterResourceId { get; set; }

        public virtual TResource CharacterResource { get; set; }
        public virtual TCharacter ResourceVersion { get; set; }
    }
}
