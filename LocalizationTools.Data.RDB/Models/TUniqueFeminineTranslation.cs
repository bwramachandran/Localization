using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TUniqueFeminineTranslation
    {
        public int LanguageId { get; set; }
        public int BranchId { get; set; }
        public int StringId { get; set; }
        public int? MasculineImportSessionStringId { get; set; }
        public int? FeminineImportSessionStringId { get; set; }
    }
}
