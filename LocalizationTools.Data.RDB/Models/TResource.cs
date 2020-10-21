using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TResource
    {
        public TResource()
        {
            TCharacterCasting = new HashSet<TCharacterCasting>();
            TCharacterCastingActor = new HashSet<TCharacterCastingActor>();
            TCharacterSubCharacter = new HashSet<TCharacterSubCharacter>();
            TCharacterVoice = new HashSet<TCharacterVoice>();
            TConversationExertionPalette = new HashSet<TConversationExertionPalette>();
            TConversationLine = new HashSet<TConversationLine>();
            TConversationLineTransition = new HashSet<TConversationLineTransition>();
            TGrammarEnumerationNounGenderResource = new HashSet<TGrammarEnumeration>();
            TGrammarEnumerationNounNumberResource = new HashSet<TGrammarEnumeration>();
            TGrammarEnumerationPhraseElementResource = new HashSet<TGrammarEnumeration>();
            TGrammarEnumerationPhraseTemplateResource = new HashSet<TGrammarEnumeration>();
            TGrammarEnumerationWordClassResource = new HashSet<TGrammarEnumeration>();
            TResourceHistory = new HashSet<TResourceHistory>();
            TResourceVersion = new HashSet<TResourceVersion>();
            TResourceVersionStringSpeaker = new HashSet<TResourceVersionStringSpeaker>();
            TStringCloneEvent = new HashSet<TStringCloneEvent>();
            TVoice = new HashSet<TVoice>();
        }

        public string ResourceUniqueId { get; set; }
        public int BranchId { get; set; }
        public int ResourceId { get; set; }

        public virtual TBranch Branch { get; set; }
        public virtual ICollection<TCharacterCasting> TCharacterCasting { get; set; }
        public virtual ICollection<TCharacterCastingActor> TCharacterCastingActor { get; set; }
        public virtual ICollection<TCharacterSubCharacter> TCharacterSubCharacter { get; set; }
        public virtual ICollection<TCharacterVoice> TCharacterVoice { get; set; }
        public virtual ICollection<TConversationExertionPalette> TConversationExertionPalette { get; set; }
        public virtual ICollection<TConversationLine> TConversationLine { get; set; }
        public virtual ICollection<TConversationLineTransition> TConversationLineTransition { get; set; }
        public virtual ICollection<TGrammarEnumeration> TGrammarEnumerationNounGenderResource { get; set; }
        public virtual ICollection<TGrammarEnumeration> TGrammarEnumerationNounNumberResource { get; set; }
        public virtual ICollection<TGrammarEnumeration> TGrammarEnumerationPhraseElementResource { get; set; }
        public virtual ICollection<TGrammarEnumeration> TGrammarEnumerationPhraseTemplateResource { get; set; }
        public virtual ICollection<TGrammarEnumeration> TGrammarEnumerationWordClassResource { get; set; }
        public virtual ICollection<TResourceHistory> TResourceHistory { get; set; }
        public virtual ICollection<TResourceVersion> TResourceVersion { get; set; }
        public virtual ICollection<TResourceVersionStringSpeaker> TResourceVersionStringSpeaker { get; set; }
        public virtual ICollection<TStringCloneEvent> TStringCloneEvent { get; set; }
        public virtual ICollection<TVoice> TVoice { get; set; }
    }
}
