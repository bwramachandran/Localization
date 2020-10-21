using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCharacterRace
    {
        public TCharacterRace()
        {
            TCharacter = new HashSet<TCharacter>();
        }

        public int CharacterRaceId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TCharacter> TCharacter { get; set; }
    }
}
