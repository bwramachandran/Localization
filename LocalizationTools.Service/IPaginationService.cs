using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTools.Service
{
    public interface IPaginationService
    {
        int CalculateTotalPage(int totalCount, int pageSize);
        string GetPreviousPageLink(int pageNumber);
        string GetNextPageLink(int pageNumber, int totalPages);
    }
}
