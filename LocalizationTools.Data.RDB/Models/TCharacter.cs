using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCharacter
    {
        public TCharacter()
        {
            TCharacterSubCharacter = new HashSet<TCharacterSubCharacter>();
            TCharacterVoice = new HashSet<TCharacterVoice>();
        }

        public int ResourceVersionId { get; set; }
        public string Name { get; set; }
        public bool IsPlayer { get; set; }
        public bool IsVoeligible { get; set; }
        public string AgeRange { get; set; }
        public string Description { get; set; }
        public int CharacterTypeId { get; set; }
        public int CharacterGenderId { get; set; }
        public int CharacterRaceId { get; set; }
        public string Accent { get; set; }
        public string RelationshipToPlayer { get; set; }
        public string Appearance { get; set; }
        public string Archetype { get; set; }
        public string TiesToOtherCharacters { get; set; }

        public virtual TCharacterGender CharacterGender { get; set; }
        public virtual TCharacterRace CharacterRace { get; set; }
        public virtual TCharacterType CharacterType { get; set; }
        public virtual TResourceVersion ResourceVersion { get; set; }
        public virtual ICollection<TCharacterSubCharacter> TCharacterSubCharacter { get; set; }
        public virtual ICollection<TCharacterVoice> TCharacterVoice { get; set; }
    }
}
