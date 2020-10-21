using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TConversation
    {
        public TConversation()
        {
            TConversationLine = new HashSet<TConversationLine>();
        }

        public int ResourceVersionId { get; set; }
        public string Synopsis { get; set; }
        public int ConversationTypeId { get; set; }
        public int? EditingPointOfContactNameId { get; set; }
        public int? CineDesignPointOfContactNameId { get; set; }
        public int? ComplexityNameId { get; set; }

        public virtual TCaseInsensitiveName CineDesignPointOfContactName { get; set; }
        public virtual TCaseInsensitiveName ComplexityName { get; set; }
        public virtual TConversationType ConversationType { get; set; }
        public virtual TCaseInsensitiveName EditingPointOfContactName { get; set; }
        public virtual TResourceVersion ResourceVersion { get; set; }
        public virtual ICollection<TConversationLine> TConversationLine { get; set; }
    }
}
