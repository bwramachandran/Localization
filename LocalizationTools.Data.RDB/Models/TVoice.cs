using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVoice
    {
        public int ResourceVersionId { get; set; }
        public string Name { get; set; }
        public string VoproductionFilenameCategory { get; set; }
        public string VopipelineFilenameVariant { get; set; }
        public bool IsPlayer { get; set; }
        public int? DefaultVoiceForCharacterResourceId { get; set; }

        public virtual TResource DefaultVoiceForCharacterResource { get; set; }
        public virtual TResourceVersion ResourceVersion { get; set; }
    }
}
