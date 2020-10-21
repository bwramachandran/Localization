using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TRepositoryPath
    {
        public TRepositoryPath()
        {
            TResourceVersion = new HashSet<TResourceVersion>();
        }

        public int RepositoryPathId { get; set; }
        public string Path { get; set; }

        public virtual ICollection<TResourceVersion> TResourceVersion { get; set; }
    }
}
