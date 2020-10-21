using LocalizationTools.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTools.Data.RDB.Functions
{
    public interface IFunction
    {
        //GetRawForeignVOForecastingDataModel Udf_GetRawForeignVOForecastingData();
        List<RemovedStringDto> Udf_GetRemovedStrings(int branchId, DateTime? sinceUTC);
        ResourceString Udf_GetResourceInformationForResourceVersionIDs(int resourceVersionId);
        Speakers Udf_GetResourceVersionStringListener(int resourceVersionId, int stringId);
        List<GetConversationLineParent> Udf_GetConversationLineParent(int resourceVersionId, int stringId);
        List<GetConversationLineChildren> Udf_GetConversationLineChildren(int resourceVersionId, int stringId);
        DocumentContent GetDocumentContent(int resourceId);
        GetStringExportCloneStatus Udf_GetStringExportCloneStatus(int branchId, int translationPartnerId);
    }
}
