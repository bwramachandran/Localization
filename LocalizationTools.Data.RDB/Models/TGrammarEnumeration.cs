using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TGrammarEnumeration
    {
        public int GrammarEnumerationId { get; set; }
        public int BranchId { get; set; }
        public bool IsActive { get; set; }
        public int? DataImportSessionId { get; set; }
        public int? ChangelistId { get; set; }
        public int? NounGenderResourceId { get; set; }
        public int? NounNumberResourceId { get; set; }
        public int? PhraseElementResourceId { get; set; }
        public int? PhraseTemplateResourceId { get; set; }
        public int? WordClassResourceId { get; set; }

        public virtual TBranch Branch { get; set; }
        public virtual TChangelist Changelist { get; set; }
        public virtual TDataImportSession DataImportSession { get; set; }
        public virtual TResource NounGenderResource { get; set; }
        public virtual TResource NounNumberResource { get; set; }
        public virtual TResource PhraseElementResource { get; set; }
        public virtual TResource PhraseTemplateResource { get; set; }
        public virtual TResource WordClassResource { get; set; }
    }
}
