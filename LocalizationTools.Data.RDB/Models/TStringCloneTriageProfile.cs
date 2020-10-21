using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TStringCloneTriageProfile
    {
        public TStringCloneTriageProfile()
        {
            TStringCloneTriage = new HashSet<TStringCloneTriage>();
        }

        public int StringCloneTriageProfileId { get; set; }
        public string Name { get; set; }
        public bool ManageMasterLanguageVo { get; set; }
        public bool ManageTranslations { get; set; }
        public int? TranslationPartnerId { get; set; }

        public virtual TTranslationPartner TranslationPartner { get; set; }
        public virtual ICollection<TStringCloneTriage> TStringCloneTriage { get; set; }
    }
}
