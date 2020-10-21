using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TGenericEnumeration
    {
        public int ResourceVersionId { get; set; }
        public int EnumerationId { get; set; }
        public string EnumerationName { get; set; }

        public virtual TResourceVersion ResourceVersion { get; set; }
    }
}
