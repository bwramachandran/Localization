using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTools.Service
{
    public class PaginationService : IPaginationService
    {
        public int CalculateTotalPage(int totalCount, int pageSize)
        {
            return (int)Math.Ceiling((double)totalCount / pageSize);
        }
        public string GetPreviousPageLink(int pageNumber)
        {
            return pageNumber > 0 ? "http://localhost:64941/api/bwtools/locApi?pageNumber=" + (pageNumber - 1) + "&pageSize=" + pageNumber : ""; //urlHelper.Link("multiStreamEnglishString", new { page = page - 1, pageSize = pageSize }) : "";
        }
        public string GetNextPageLink(int pageNumber, int totalPages)
        {
            return pageNumber < totalPages - 1 ? "http://localhost:64941/api/bwtools/locApi?pageNumber=" + (pageNumber + 1) + "&pageSize=" + pageNumber : "";
        }
    }
}
