using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVosession
    {
        public TVosession()
        {
            TVosessionData = new HashSet<TVosessionData>();
            TVosessionScript = new HashSet<TVosessionScript>();
        }

        public int VosessionId { get; set; }
        public int LanguageId { get; set; }

        public virtual ICollection<TVosessionData> TVosessionData { get; set; }
        public virtual ICollection<TVosessionScript> TVosessionScript { get; set; }
    }
}
