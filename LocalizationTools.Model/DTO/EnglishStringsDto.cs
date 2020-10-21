using System;
using System.Collections.Generic;

namespace LocalizationTools.Model.DTO
{
    public class EnglishStringsDto
    {
        public string PrevPage { get; set; }
        public string NextPage { get; set; }
        public int PageCount { get; set; }
        public List<DocumentInformation> ContextDocument { get; set; } = new List<DocumentInformation>();
    }
    public class DocumentInformation
    {
        public List<int> VoScriptIds { get; set; } = new List<int>();
        public DocumentContent DocumentContent { get; set; } = new DocumentContent();
        public List<TextInfomationDto> ResourceInformation { get; set; } = new List<TextInfomationDto>();
    }
    public class DocumentContent
    {
        public int ResourceVersionId { get; set; }
        public int ProductionStateId { get; set; }
        public string ResourceFolder { get; set; }
        public string ResourceName { get; set; }
        public int ResourceTypeId { get; set; }
        public string ScopeSubTag { get; set; }
        public string ScopeTag { get; set; }
        public string TypeTag { get; set; }
        public int WritingWorkFlowStatusId { get; set; }
        public ResourceInformation ResourceInformation { get; set; } = new ResourceInformation();
    }
    public class ResourceInformation
    {
        public string Complexity { get; set; }
        public string Synopsis { get; set; }
    }
    public class EnglishStringListDto
    {
        public int StringId { get; set; }
        public int LocalizedVersionId { get; set; }
        public int BranchId { get; set; }
        public int WordCount { get; set; }
        public int ResourceVersionId { get; set; }
        public int ResourceId { get; set; }
        public int TimingRestriction { get; set; }
        public string ProjectResourceUniqueId { get; set; }
        public string VoComment { get; set; }
        public string EditorComment { get; set; }
        public string ProductionStatus { get; set; }
        public bool IsLocalizationReady { get; set; }
        public RemovedStringDto RemoveStrings { get; set; } = new RemovedStringDto();
        public bool IsClone { get; set; }
        public int? SourceStringId { get; set; }
    }
    public class TextInfomationDto
    {
        public EnglishStringListDto EnglishStrings { get; set; } = new EnglishStringListDto();
        public int LineOrder { get; set; }
        public string CurrentText { get; set; }
        public string Description { get; set; }
        public int FriendlyStringId { get; set; }
        public List<GrammarInfo> GrammarInfo { get; set; } = new List<GrammarInfo>();
        public bool IsClone { get; set; } = true;
        public bool IsTranslationEligible { get; set; }
        public List<Links> Links { get; set; } = new List<Links>();
        public int LocalizedVersionId { get; set; }
        public int? MaxCharacterLength { get; set; }
        public List<ParentResource> ParentResource { get; set; } = new List<ParentResource>();
        public string PreviousText { get; set; }
        public string RecordingTypeName { get; set; }
        public RequiresTranslationState RequiresTranslationState { get; set; } = new RequiresTranslationState();
        public int SourceCloneStringId { get; set; }
        public bool IsHoverText { get; set; } = false;
        public bool IsParaphrase { get; set; } = false;
        public List<Speakers> Speakers { get; set; } = new List<Speakers>();
        public int StringId { get; set; }
        public StringType StringType { get; set; } = new StringType();
        public TimingRestriction TimingRestriction { get; set; }
        public int WordCount { get; set; }
        //public string ResourceFolder { get; set; }
        //public string ResourceName { get; set; }
        //public string ResourceType { get; set; }
    }
    public class Links
    {
        public List<GetConversationLineParent> Parent { get; set; } = new List<GetConversationLineParent>();
        public List<GetConversationLineChildren> Children { get; set; } = new List<GetConversationLineChildren>();
    }
    
    public class StringType
    {
        public int StringTypeId { get; set; }
        public string StringTypeName { get; set; }
    }
    public class Speakers
    {
        public string Age { get; set; }
        public string Name { get; set; }
        public bool IsPlayer { get; set; }
        public string Gender { get; set; }
    }
    public class GetStringExportCloneStatus
    {
        public int? SourceStringId { get; set; }
    }
    public class ParentResource
    {
        public int LocalizationResourceId { get; set; }
        public int LocalizationResourceVersionId { get; set; }
    }
   
    public class RemovedStringDto
    {
        public int RemovalTypeId{ get; set; }
        public string RemovalType { get; set; }
        public int StringId { get; set; }
    }
    public class EnglishStringPayload
    {
        public List<int> ResourceIds { get; set; } = new List<int> { 27819, 24004 };
        public DateTime? ModifiedDateUTC { get; set; }
        public bool IsLocalizationReady { get; set; } = true;
        public int? BranchId { get; set; } = 7;
        public int TranslationPartnerId { get; set; } = 1;
    }
    public enum RequiresTranslation
    {
        /// <summary>
        /// Does not require translation
        /// </summary>
        None = 0,
        /// <summary>
        /// Has never been translated before and requires one.
        /// </summary>
        New,
        /// <summary>
        /// Requires a minor translation.
        /// </summary>
        Minor,
        /// <summary>
        /// Requires a major translation.
        /// </summary>
        Major
    }
    public enum TranslationState
    {
        Unassigned, // initialization value - should never be used in regular operations
        Unchanged, // string is the same as last time the translation partner received it
        Updated, // string requires re-translation
        New, // string requires (first-time) translation
        DoNotTranslate // string should not be translated (it is provided for context against other strings/completeness of resource)
    }
    public enum RequiresTranslationState
    {
        Unassigned, // initialization value - should never be used in regular operations
        Unchanged, // string is the same as last time the translation partner received it
        Updated, // string requires re-translation
        New, // string requires (first-time) translation
        DoNotTranslate // string should not be translated (it is provided for context against other strings/completeness of resource)
    }

}
