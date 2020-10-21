using LocalizationTools.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTools.Data.LocAPI
{
    public interface IDataServiceLocAPI
    {
        List<DocumentInformation> GetAllEnglishStrings(EnglishStringPayload payload);
    }
}
