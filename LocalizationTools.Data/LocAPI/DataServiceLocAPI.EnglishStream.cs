using LocalizationTools.Model.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocalizationTools.Data.LocAPI
{
    public partial class DataServiceLocAPI : IDataServiceLocAPI
    {
        private EnglishStringPayload m_payload;
        private List<RemovedStringDto> m_removalStringList;
        /// Algo
        ///1. Document Information.
        ///2. List of Resource Information
        ///     2.a. String Information
        ///         2.a.i. Removal Information
        public List<DocumentInformation> GetAllEnglishStrings(EnglishStringPayload payload)
        {
            m_payload = payload;
            List<DocumentInformation> documentInformationList = new List<DocumentInformation>();
            try
            {
                m_removalStringList = m_functionService.Udf_GetRemovedStrings(payload.BranchId.Value, payload.ModifiedDateUTC);
                foreach (var resourceId in payload.ResourceIds)
                {
                    ///DocumentContent
                    DocumentInformation documentInformation = new DocumentInformation
                    {
                        DocumentContent = m_functionService.GetDocumentContent(resourceId),
                        VoScriptIds = m_dbContext.TVoscript
                                        .Where(x => x.BranchId == payload.BranchId)
                                        .Where(x => x.ParentResourceId == resourceId)
                                        .Where(x => x.IsActive)
                                        .Select(x => x.VoscriptId)
                                        .ToList()
                    };

                    var resourceVersionIdList = new List<int> { documentInformation.DocumentContent.ResourceVersionId };

                    foreach (var resourceVersionId in resourceVersionIdList)
                    {
                        ParentResource parentResource = new ParentResource
                        {
                            LocalizationResourceId = resourceId,//parentResourceAttributes.ResourceID,
                            LocalizationResourceVersionId = resourceVersionId//resourceVersionId,
                        };
                        documentInformation.ResourceInformation.AddRange(GetTextInformation(resourceVersionId, parentResource));
                    }
                    documentInformationList.Add(documentInformation);
                }
            }
            catch(Exception ex)
            {
                m_loggerService.LogError(ex.Message);
            }
            
            return documentInformationList;
        }
        public List<TextInfomationDto> GetTextInformation(int resourceVersionId, ParentResource parentResource)
        {
            var resourceInformationList = new List<TextInfomationDto>();

            var resourceString = m_procedureService.GetStringDataForResourceVersionIDs(resourceVersionId);
            var lineOrder = 1;
            foreach(var item in resourceString.stringDataForResourceVersionID)
            {
                TextInfomationDto textInfomationDto = new TextInfomationDto
                {
                    Description = GetDescription(item),
                    CurrentText = item.Text,
                    IsTranslationEligible = item.IsTranslationEligible,
                    FriendlyStringId = item.FriendlyStringId,
                    StringId = item.StringId,
                    LocalizedVersionId = item.LocalizedVersionId,
                    MaxCharacterLength = item.MaxCharacterLength,
                    RecordingTypeName = item.RecordingTypeName,
                    TimingRestriction = ConvertStringTimeConstraintToDocumentTimingRestriction(item.TimingRestriction),
                    WordCount = item.WordCount,
                    LineOrder = lineOrder++,
                };
                GetStringTypeInformation(item, textInfomationDto);
                bool previouslyExported = SetPreviousText(resourceString, item, textInfomationDto);
                TranslationState translationState = previouslyExported ? TranslationState.Unchanged : TranslationState.DoNotTranslate;
                textInfomationDto.RequiresTranslationState = ConvertToRequiresTranslationState(translationState);
                GetSetGrammarInformation(resourceString, item, textInfomationDto);
                
                Links link = new Links();
                link.Parent.AddRange(m_functionService.Udf_GetConversationLineParent(resourceVersionId, textInfomationDto.StringId));
                link.Children.AddRange(GetChildLinkInfo(resourceVersionId, textInfomationDto));
                textInfomationDto.Links.Add(link);

                textInfomationDto.ParentResource.Add(parentResource);

                textInfomationDto.Speakers.Add(m_functionService.Udf_GetResourceVersionStringListener(resourceVersionId, item.StringId));

                GetSetEnglishStrings(textInfomationDto);
                resourceInformationList.Add(textInfomationDto);
            }
            return resourceInformationList;
        }
        private List<GetConversationLineChildren> GetChildLinkInfo(int resourceVersionId, TextInfomationDto textInfomationDto)
        {
            var child = m_functionService.Udf_GetConversationLineChildren(resourceVersionId, textInfomationDto.StringId);
            foreach(var childItem in child)
            {
                var conversationLines = m_dbContext.TConversationLine
                        .Where(x => x.ResourceVersionId == resourceVersionId)
                        .Where(x => x.TextStringId == childItem.StringId);
                var hoverTextStringId = conversationLines.Select(x => x.HoverTextStringId).FirstOrDefault();
                childItem.HoverTextStringId = hoverTextStringId ?? 0;
                childItem.HasHoverText = hoverTextStringId.HasValue;
                if(!textInfomationDto.IsHoverText && childItem.HasHoverText)
                {
                    textInfomationDto.IsHoverText = true;
                }
                var paraphraseStringID = conversationLines.Select(x => x.ParaphraseStringId).FirstOrDefault();
                childItem.ParaphraseStringId = paraphraseStringID ?? 0;
                childItem.HasParaphrase = paraphraseStringID.HasValue;
                if(!textInfomationDto.IsParaphrase && childItem.HasParaphrase)
                {
                    textInfomationDto.IsParaphrase = true;
                }
            }
            
            return child;
        }
        private void GetSetEnglishStrings(TextInfomationDto textInfomationDto)
        {
            textInfomationDto.EnglishStrings = m_procedureService.StringExportStatusAndInfos(m_payload.IsLocalizationReady,
                                                                                        m_payload.ModifiedDateUTC,
                                                                                        textInfomationDto.StringId,
                                                                                        m_payload.BranchId.Value);

            if (textInfomationDto.EnglishStrings == null || !textInfomationDto.EnglishStrings.SourceStringId.HasValue || !textInfomationDto.EnglishStrings.IsClone)
            {
                textInfomationDto.IsClone = false;
            }
            textInfomationDto.SourceCloneStringId = textInfomationDto.EnglishStrings.SourceStringId ?? 0;
            GetSetEnglishStringRemovalInformation(textInfomationDto);
        }
        private void GetSetEnglishStringRemovalInformation(TextInfomationDto textInfomationDto)
        {
            var removeStrings = m_removalStringList.Where(x => x.StringId == textInfomationDto.StringId).FirstOrDefault();
            if (removeStrings == null)
            {
                textInfomationDto.EnglishStrings.RemoveStrings = null;
            }
            else
            {
                RemovedStringDto RemoveStrings = new RemovedStringDto
                {
                    RemovalTypeId = removeStrings.RemovalTypeId,
                    RemovalType = removeStrings.RemovalType
                };
                textInfomationDto.EnglishStrings.RemoveStrings = removeStrings;
            }
        }
        private static void GetSetGrammarInformation(Attributes resourceString, StringDataForResourceVersionID item, TextInfomationDto textInfomationDto)
        {
            var grammarInformation = resourceString.GrammarInfo.Where(x => x.StringId == item.StringId).ToList();
            if (grammarInformation.Count > 0)
            {
                foreach (var gInfo in grammarInformation)
                {
                    GrammarInfo grammar = new GrammarInfo
                    {
                        WordClassId = gInfo.WordClassId,
                        PhraseTemplateId = gInfo.PhraseTemplateId,
                        PhraseElementId = gInfo.PhraseElementId,
                        ModifierPositionId = gInfo.ModifierPositionId
                    };
                    textInfomationDto.GrammarInfo.Add(grammar);
                }
            }
        }
        private static bool SetPreviousText(Attributes resourceString, StringDataForResourceVersionID item, TextInfomationDto textInfomationDto)
        {
            bool previouslyExported = resourceString != null;
            if (previouslyExported)
            {
                textInfomationDto.PreviousText = item.Text;
            }
            else
            {
                textInfomationDto.PreviousText = string.Empty;
            }

            return previouslyExported;
        }
        private void GetStringTypeInformation(StringDataForResourceVersionID item, TextInfomationDto textInfomationDto)
        {
            textInfomationDto.StringType.StringTypeId = item.StringTypeId;
            textInfomationDto.StringType.StringTypeName = item.StringTypeName;
        }
        private RequiresTranslationState ConvertToRequiresTranslationState(TranslationState translationState)
        {
            return translationState switch
            {
                TranslationState.DoNotTranslate => RequiresTranslationState.DoNotTranslate,
                TranslationState.New => RequiresTranslationState.New,
                TranslationState.Unassigned => RequiresTranslationState.Unassigned,
                TranslationState.Unchanged => RequiresTranslationState.Unchanged,
                TranslationState.Updated => RequiresTranslationState.Updated,
                                                        _ => throw new Exception(string.Format(
                                        "Unknown or unsupported TranslationState: {0}",
                                        translationState.ToString()
                                        )),
            };
        }
        private string GetDescription(StringDataForResourceVersionID attributes)
        {
            var descriptions = new List<string>();
            var sourceCloneStringId = m_functionService.Udf_GetStringExportCloneStatus(m_payload.BranchId.Value, m_payload.TranslationPartnerId);
            if (sourceCloneStringId.SourceStringId != 0 && sourceCloneStringId != null)
            {
                descriptions.Add(string.Format("(Clone of String ID {0})",sourceCloneStringId.SourceStringId.HasValue ? sourceCloneStringId.SourceStringId.ToString() : "{UNKNOWN}"));
            }
            if (!string.IsNullOrWhiteSpace(attributes.VOComment))
            {
                descriptions.Add(string.Format("(VO) {0}",attributes.VOComment));
            }
            if (!string.IsNullOrWhiteSpace(attributes.EditorComment))
            {
                descriptions.Add(string.Format("(EDITOR) {0}",attributes.EditorComment));
            }
            return string.Join(Environment.NewLine, descriptions
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Distinct()
                .ToArray());
        }
        private TimingRestriction ConvertStringTimeConstraintToDocumentTimingRestriction(TimeConstraint timeConstraint)
        {
            return timeConstraint switch
            {
                TimeConstraint.Hard => TimingRestriction.Hard,
                TimeConstraint.None => TimingRestriction.None,
                TimeConstraint.Soft => TimingRestriction.Soft,
                TimeConstraint.Unknown => TimingRestriction.Unknown,
                _ => TimingRestriction.Unknown,
            };
        }
    }
}
