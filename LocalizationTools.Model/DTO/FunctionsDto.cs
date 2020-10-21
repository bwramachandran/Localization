using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTools.Model.DTO
{
    public class FunctionsDto
    {
        public int LineId { get; set; }
        public Conversation Conversation { get; set; }
        public ConversationLine ParentLine { get; set; }
        public int? ParaphraseCategoryResourceId { get; set; }
        public StringAttributes Attributes { get; set; }
    }
    public class StringOwnerInformation
    {
        public int StringId { get; set; }
        public int ResourceId { get; set; }
        public int ResourceVersionID { get; set; }
        public int StringTypeID { get; set; }
    }
    public class ResourceString
    {
        public string StringId { get; set; }
        public int FriendlyStringId { get; set; }
        public string StringUniqueId { get; set; }
        public int ResourceVersionID { get; set; }
        public int ResourceID { get; set; }
        public int BranchID { get; set; }
        public string Status { get; set; }
        public string Folder { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string RepositoryPath { get; set; }
        public string WritingPointOfContact { get; set; }
        public int TypeTag { get; set; }
        public string ScopeSubTag { get; set; }
        public int ResourceTypeID { get; set; }
        public int ProjectVersion { get; set; }
        public string ScopeTag { get; set; }
        public int DataImportSessionID { get; set; }
        public int ModuleID { get; set; }
        public int WritingWorkflowStateID { get; set; }
        public int ProductionStateID { get; set; }
        public int ModelTypeID { get; set; }
        public string ResourceUniqueID { get; set; }
        public int ChangelistID { get; set; }
    }

    public class StringAttributes 
    { 
        public static readonly int MaxTextFieldLength = 3000;

        public static readonly int UnlimitedMaxCharacterLength = 0;
        public string Text { get; set; }
        public bool TextTruncated { get { return (Text.Length > MaxTextFieldLength); } }
        public int StringTypeId { get; set; }
    }
    public class Conversation
    {
        public string Synopsis { get; set; }
        public IList<FunctionsDto> RootNodes { get; set; } = new List<FunctionsDto>();
    }
    public class ConversationLine
    {
        public string Text { get; set; }
        public string CinematicsComment { get; set; }
        public string DesignComment { get; set; }
        public IList<FunctionsDto> Children { get; set; } = new List<FunctionsDto>();
    }

    public class Attributes
    {
        public List<StringDataForResourceVersionID> stringDataForResourceVersionID { get; set; } = new List<StringDataForResourceVersionID>();
        public List<StringSpeakerCharacter> stringSpeakerCharacter { get; set; } = new List<StringSpeakerCharacter>();
        public List<GrammarInfo> GrammarInfo { get; set; } = new List<GrammarInfo>();
    }
    public class GetStringExportStatusAndInfo
    {
        public bool IsClone { get; set; }
        public int? SourceStringId { get; set; }
    }
    public class GrammarInfo
    {
        public int StringId { get; set; }
        public int WordClassId { get; set; }
        public int PhraseElementId { get; set; }
        public int PhraseTemplateId { get; set; }
        public int ModifierPositionId { get; set; }
    }
    public class StringDataForResourceVersionID
    {
        public int StringId { get; set; }
        public int FriendlyStringId { get; set; }
        public string Text { get; set; }
        public int WordCount { get; set; }
        public bool IsTranslationEligible { get; set; }
        public int LocalizedVersionId { get; set; }
        public int? MaxCharacterLength { get; set; }
        public int StringTypeId { get; set; }
        public string StringTypeName { get; set; }
        public TimeConstraint TimingRestriction { get; set; }
        public string VOComment { get; set; }
        public string EditorComment { get; set; }
        public int RecordingTypeId { get; set; }
        public string RecordingTypeName { get; set; }
        public int? ListenerCharacterResourceID { get; set; }
    }
    public class GetConversationLineParent
    {
        public int StringId { get; set; }
        public bool IsSoftLink { get; set; }
    }
    public class GetConversationLineChildren
    {
        public int StringId { get; set; }
        public bool IsSoftLink { get; set; }
        public int ParaphraseStringId { get; set; }
        public bool HasHoverText { get; set; }
        public bool HasParaphrase { get; set; }
        public int HoverTextStringId { get; set; }
    }
    public class StringSpeakerCharacter
    {
        public int StringId { get; set; }
        public int CharacterResourceId { get; set; }
        public bool IsVOEligible { get; set; }
        public bool IsVOReRecord { get; set; }
        public int ResourceVersionId { get; set; }
        public DateTime VORequestOnUTC { get; set; }
        public int VORequestResourceVersionId { get; set; }
    }
    public class Character
    {
        public string Age { get; set; }
        public string Name { get; set; }
        public bool IsPlayer { get; set; }
        public string Gender { get; set; }
    }
    public enum TimeConstraint
    {
        Unknown = -1,
        None = 0,
        Soft = 1,
        Hard = 2
    }
    public enum TimingRestriction
    {
        Unassigned, // initialization value - should never be used in regular operations
        Unknown, // The project has specified an unknown/unexpected Timing Restriction
        None, // The string has no known restrictions
        Soft, // The string should loosely follow Master Language lengths
        Hard // The string should strictly follow Master Language lengths
    }
}
