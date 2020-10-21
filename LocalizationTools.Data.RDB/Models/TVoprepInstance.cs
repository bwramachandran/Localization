using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVoprepInstance
    {
        public TVoprepInstance()
        {
            TVoprepInstanceString = new HashSet<TVoprepInstanceString>();
        }

        public int VoprepInstanceId { get; set; }
        public string PrepToken { get; set; }
        public int VoscriptId { get; set; }
        public string Verbosity { get; set; }
        public bool UseRoleAsSpeaker { get; set; }
        public int ParentResourceVersionId { get; set; }
        public int VoiceResourceVersionId { get; set; }

        public virtual TVoscript Voscript { get; set; }
        public virtual ICollection<TVoprepInstanceString> TVoprepInstanceString { get; set; }
    }
}
