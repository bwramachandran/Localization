using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TConversationLineTransition
    {
        public int ConversationLineTransitionId { get; set; }
        public int ResourceVersionId { get; set; }
        public int? ParentLineId { get; set; }
        public int ChildLineId { get; set; }
        public bool IsSoftLink { get; set; }
        public bool IsParaphraseOverride { get; set; }
        public int? HoverTextStringId { get; set; }
        public int? ParaphraseStringId { get; set; }
        public int? ParaphraseCategoryResourceId { get; set; }

        public virtual TResource ParaphraseCategoryResource { get; set; }
        public virtual TConversationLine TConversationLine { get; set; }
        public virtual TConversationLine TConversationLineNavigation { get; set; }
    }
}
