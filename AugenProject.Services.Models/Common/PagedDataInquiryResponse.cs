using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AugenProject.Services.Models.Common
{
    public class PagedDataInquiryResponse<T>
    {
        private List<T> _items;

        public List<T> Items
        {
            get { return _items ?? (_items = new List<T>()); }
            set { _items = value; }
        }

        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int PageCount { get; set; }
        public int TotalCount { get; set; }
    }
}