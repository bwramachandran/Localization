using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TResourceVersion
    {
        public TResourceVersion()
        {
            InversePreviousResourceVersion = new HashSet<TResourceVersion>();
            TGenericEnumeration = new HashSet<TGenericEnumeration>();
            TJournalNode = new HashSet<TJournalNode>();
            TResourceVersionString = new HashSet<TResourceVersionString>();
            TStringCloneEventCloneResourceVersion = new HashSet<TStringCloneEvent>();
            TStringCloneEventSourceResourceVersion = new HashSet<TStringCloneEvent>();
        }

        public int ResourceVersionId { get; set; }
        public int ResourceId { get; set; }
        public int BranchId { get; set; }
        public string Status { get; set; }
        public int FolderResourceNameId { get; set; }
        public int NameResourceNameId { get; set; }
        public int ModelTypeId { get; set; }
        public string FullName { get; set; }
        public int ResourceTypeId { get; set; }
        public int? RepositoryPathId { get; set; }
        public int ProjectVersion { get; set; }
        public int? DataImportSessionId { get; set; }
        public int? ChangelistId { get; set; }
        public int ModuleId { get; set; }
        public int WritingWorkflowStateId { get; set; }
        public int ProductionStateId { get; set; }
        public int? PreviousResourceVersionId { get; set; }
        public int? ScopeTagCaseInsensitiveNameId { get; set; }
        public int? ScopeSubTagCaseInsensitiveNameId { get; set; }
        public int? TypeTagCaseInsensitiveNameId { get; set; }
        public int? WritingPointOfContactNameId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual TChangelist Changelist { get; set; }
        public virtual TDataImportSession DataImportSession { get; set; }
        public virtual TResourceName FolderResourceName { get; set; }
        public virtual TModelType ModelType { get; set; }
        public virtual TModule Module { get; set; }
        public virtual TResourceName NameResourceName { get; set; }
        public virtual TResourceVersion PreviousResourceVersion { get; set; }
        public virtual TProductionState ProductionState { get; set; }
        public virtual TRepositoryPath RepositoryPath { get; set; }
        public virtual TResource Resource { get; set; }
        public virtual TResourceType ResourceType { get; set; }
        public virtual TCaseInsensitiveName ScopeSubTagCaseInsensitiveName { get; set; }
        public virtual TCaseInsensitiveName ScopeTagCaseInsensitiveName { get; set; }
        public virtual TCaseInsensitiveName TypeTagCaseInsensitiveName { get; set; }
        public virtual TCaseInsensitiveName WritingPointOfContactName { get; set; }
        public virtual TWritingWorkflowState WritingWorkflowState { get; set; }
        public virtual TCharacter TCharacter { get; set; }
        public virtual TCharacterCasting TCharacterCasting { get; set; }
        public virtual TConversation TConversation { get; set; }
        public virtual TConversationExertionPalette TConversationExertionPalette { get; set; }
        public virtual TParaphraseCategory TParaphraseCategory { get; set; }
        public virtual TVoice TVoice { get; set; }
        public virtual ICollection<TResourceVersion> InversePreviousResourceVersion { get; set; }
        public virtual ICollection<TGenericEnumeration> TGenericEnumeration { get; set; }
        public virtual ICollection<TJournalNode> TJournalNode { get; set; }
        public virtual ICollection<TResourceVersionString> TResourceVersionString { get; set; }
        public virtual ICollection<TStringCloneEvent> TStringCloneEventCloneResourceVersion { get; set; }
        public virtual ICollection<TStringCloneEvent> TStringCloneEventSourceResourceVersion { get; set; }
    }
}
