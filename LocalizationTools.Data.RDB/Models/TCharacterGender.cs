using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCharacterGender
    {
        public TCharacterGender()
        {
            TCharacter = new HashSet<TCharacter>();
        }

        public int CharacterGenderId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TCharacter> TCharacter { get; set; }
    }
}
