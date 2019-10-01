using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AugenProject.Data.PagedDataRequest
{
    public class PagedDataRequest
    {
        public PagedDataRequest()
        {
            PageNumber = 1;
            PageSize = 20;
        }
        public PagedDataRequest(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
        public PagedDataRequest(int pageNumber, int pageSize, string searchText)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            SearchText = searchText;
        }

        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchText { get; set; }
    }
}