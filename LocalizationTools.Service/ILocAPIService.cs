using LocalizationTools.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTools.Service
{
    public interface ILocAPIService
    {
        EnglishStringsDto GetAllEnglishString(EnglishStringPayload payload, int pageNumber, int pageSize);
    }
}
