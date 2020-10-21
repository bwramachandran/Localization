using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TResourceName
    {
        public TResourceName()
        {
            TResourceVersionFolderResourceName = new HashSet<TResourceVersion>();
            TResourceVersionNameResourceName = new HashSet<TResourceVersion>();
        }

        public int ResourceNameId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TResourceVersion> TResourceVersionFolderResourceName { get; set; }
        public virtual ICollection<TResourceVersion> TResourceVersionNameResourceName { get; set; }
    }
}
