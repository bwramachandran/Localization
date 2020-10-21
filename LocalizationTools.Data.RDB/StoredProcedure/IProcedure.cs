using LocalizationTools.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTools.Data.RDB.StoredProcedure
{
    public interface IProcedure
    {
        Attributes GetStringDataForResourceVersionIDs(int resourceVersionId);
        GetStringExportStatusAndInfo GetStringExportStatusAndInfo(int stringId, int branchId);
        EnglishStringListDto StringExportStatusAndInfos(bool isLocalizationReady, DateTime? sinceUTC, int stringId, int branchId);
    }
}
