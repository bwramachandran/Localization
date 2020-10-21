using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TConversationExertionPalette
    {
        public int ResourceVersionId { get; set; }
        public int? ReferenceConversationResourceId { get; set; }

        public virtual TResource ReferenceConversationResource { get; set; }
        public virtual TResourceVersion ResourceVersion { get; set; }
    }
}
