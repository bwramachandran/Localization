using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TCaseInsensitiveName
    {
        public TCaseInsensitiveName()
        {
            TConversationCineDesignPointOfContactName = new HashSet<TConversation>();
            TConversationComplexityName = new HashSet<TConversation>();
            TConversationEditingPointOfContactName = new HashSet<TConversation>();
            TResourceVersionScopeSubTagCaseInsensitiveName = new HashSet<TResourceVersion>();
            TResourceVersionScopeTagCaseInsensitiveName = new HashSet<TResourceVersion>();
            TResourceVersionTypeTagCaseInsensitiveName = new HashSet<TResourceVersion>();
            TResourceVersionWritingPointOfContactName = new HashSet<TResourceVersion>();
        }

        public int CaseInsensitiveNameId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TConversation> TConversationCineDesignPointOfContactName { get; set; }
        public virtual ICollection<TConversation> TConversationComplexityName { get; set; }
        public virtual ICollection<TConversation> TConversationEditingPointOfContactName { get; set; }
        public virtual ICollection<TResourceVersion> TResourceVersionScopeSubTagCaseInsensitiveName { get; set; }
        public virtual ICollection<TResourceVersion> TResourceVersionScopeTagCaseInsensitiveName { get; set; }
        public virtual ICollection<TResourceVersion> TResourceVersionTypeTagCaseInsensitiveName { get; set; }
        public virtual ICollection<TResourceVersion> TResourceVersionWritingPointOfContactName { get; set; }
    }
}
