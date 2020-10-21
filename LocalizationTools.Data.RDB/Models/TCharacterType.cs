using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCharacterType
    {
        public TCharacterType()
        {
            TCharacter = new HashSet<TCharacter>();
        }

        public int CharacterTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TCharacter> TCharacter { get; set; }
    }
}
