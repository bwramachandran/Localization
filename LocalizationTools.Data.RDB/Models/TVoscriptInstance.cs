using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVoscriptInstance
    {
        public TVoscriptInstance()
        {
            TVoscriptInstanceString = new HashSet<TVoscriptInstanceString>();
            TVosessionScript = new HashSet<TVosessionScript>();
        }

        public int VoscriptInstanceId { get; set; }
        public int VoscriptGenerationSessionId { get; set; }
        public int VoscriptId { get; set; }
        public int LanguageId { get; set; }
        public string Status { get; set; }
        public string Verbosity { get; set; }
        public bool UseRoleAsSpeaker { get; set; }
        public int ParentResourceVersionId { get; set; }
        public int VoiceResourceVersionId { get; set; }

        public virtual TVoscript Voscript { get; set; }
        public virtual TVoscriptGenerationSession VoscriptGenerationSession { get; set; }
        public virtual ICollection<TVoscriptInstanceString> TVoscriptInstanceString { get; set; }
        public virtual ICollection<TVosessionScript> TVosessionScript { get; set; }
    }
}
