using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TVoscriptInstanceString
    {
        public TVoscriptInstanceString()
        {
            InversePreviousVoscriptInstanceString = new HashSet<TVoscriptInstanceString>();
            TVoscriptInstanceStringTriage = new HashSet<TVoscriptInstanceStringTriage>();
        }

        public int VoscriptInstanceStringId { get; set; }
        public int VoscriptInstanceId { get; set; }
        public bool IsActive { get; set; }
        public bool IsUnPrinted { get; set; }
        public DateTime CompareDate { get; set; }
        public int? PreviousVoscriptInstanceStringId { get; set; }
        public bool MasterLanguage { get; set; }
        public int ParentResourceVersionId { get; set; }
        public int StringId { get; set; }
        public string VofileName { get; set; }
        public int VariantId { get; set; }
        public int? ImportSessionStringId { get; set; }
        public DateTime LastModifiedOnUtc { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual TVoscriptInstanceString PreviousVoscriptInstanceString { get; set; }
        public virtual TResourceVersionString TResourceVersionString { get; set; }
        public virtual TVoscriptInstance VoscriptInstance { get; set; }
        public virtual ICollection<TVoscriptInstanceString> InversePreviousVoscriptInstanceString { get; set; }
        public virtual ICollection<TVoscriptInstanceStringTriage> TVoscriptInstanceStringTriage { get; set; }
    }
}
