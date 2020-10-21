using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TConversationLine
    {
        public TConversationLine()
        {
            TConversationLineTransitionTConversationLine = new HashSet<TConversationLineTransition>();
            TConversationLineTransitionTConversationLineNavigation = new HashSet<TConversationLineTransition>();
        }

        public int ResourceVersionId { get; set; }
        public int LineId { get; set; }
        public int TextStringId { get; set; }
        public int? HoverTextStringId { get; set; }
        public int? ParaphraseStringId { get; set; }
        public int? ParaphraseCategoryResourceId { get; set; }
        public string CinematicsComment { get; set; }
        public string DesignComment { get; set; }

        public virtual TResource ParaphraseCategoryResource { get; set; }
        public virtual TConversation ResourceVersion { get; set; }
        public virtual ICollection<TConversationLineTransition> TConversationLineTransitionTConversationLine { get; set; }
        public virtual ICollection<TConversationLineTransition> TConversationLineTransitionTConversationLineNavigation { get; set; }
    }
}
