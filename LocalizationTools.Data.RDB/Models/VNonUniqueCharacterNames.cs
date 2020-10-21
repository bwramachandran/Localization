using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VNonUniqueCharacterNames
    {
        public string Branch { get; set; }
        public string CharacterName { get; set; }
        public string ResourceName { get; set; }
        public string ResourceFolder { get; set; }
    }
}
