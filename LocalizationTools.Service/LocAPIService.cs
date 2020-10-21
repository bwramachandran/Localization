using Castle.Core.Logging;
using LocalizationTools.Data.LocAPI;
using LocalizationTools.Model.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LocalizationTools.Service
{
    public class LocAPIService : ILocAPIService
    {
        private readonly IDataServiceLocAPI m_locAPIService;
        private readonly IPaginationService m_paginationService;
        private readonly ILogger<LocAPIService> m_loggerService;
        public LocAPIService(IDataServiceLocAPI locAPIService, IPaginationService paginationService, ILogger<LocAPIService> loggerService)
            
        {
            m_locAPIService = locAPIService;
            m_paginationService = paginationService;
            m_loggerService = loggerService;
        }
        public EnglishStringsDto GetAllEnglishString(EnglishStringPayload payload, int pageNumber, int pageSize)
        {
            EnglishStringsDto result = new EnglishStringsDto();
            try
            {
                var resourceInformationList = m_locAPIService.GetAllEnglishStrings(payload);
                var totalCount = resourceInformationList.Count;
                var totalPages = m_paginationService.CalculateTotalPage(totalCount, pageSize);
                result.PrevPage = m_paginationService.GetPreviousPageLink(pageNumber);
                result.NextPage = m_paginationService.GetNextPageLink(pageNumber, totalPages);
                result.ContextDocument = resourceInformationList.Skip(pageSize * pageNumber)
                                                .Take(pageSize).ToList();
            }
            catch(Exception ex)
            {
                m_loggerService.LogError(ex.Message);
            }
            return result;
        }
    }
}
