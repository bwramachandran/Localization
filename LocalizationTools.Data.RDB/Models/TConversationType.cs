using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TConversationType
    {
        public TConversationType()
        {
            TConversation = new HashSet<TConversation>();
        }

        public int ConversationTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TConversation> TConversation { get; set; }
    }
}
