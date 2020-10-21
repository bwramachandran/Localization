using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TResourceVersionStringComment
    {
        public int ResourceVersionId { get; set; }
        public int StringId { get; set; }
        public string EditorComment { get; set; }
        public string Vocomment { get; set; }

        public virtual TResourceVersionString TResourceVersionString { get; set; }
    }
}
