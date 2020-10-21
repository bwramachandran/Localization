using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TStringVoenum
    {
        public TStringVoenum()
        {
            TResourceVersionStringActorIntensityStringVoenum = new HashSet<TResourceVersionString>();
            TResourceVersionStringActorVolumeStringVoenum = new HashSet<TResourceVersionString>();
        }

        public int StringVoenumId { get; set; }
        public string DisplayName { get; set; }

        public virtual ICollection<TResourceVersionString> TResourceVersionStringActorIntensityStringVoenum { get; set; }
        public virtual ICollection<TResourceVersionString> TResourceVersionStringActorVolumeStringVoenum { get; set; }
    }
}
