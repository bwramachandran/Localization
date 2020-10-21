using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VCharacterGenderRace
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public bool IsPlayer { get; set; }
    }
}
