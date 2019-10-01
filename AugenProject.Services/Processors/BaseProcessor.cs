using AugenProject.Common;
using AugenProject.Services.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AugenProject.Services.Processors
{
    public class BaseProcessor
    {
        protected PagedDataInquiryResponse<TModel> WrapPagedResponse<TModel, TEntity>
            (QueryResult<TEntity> queryResult, Data.PagedDataRequest.PagedDataRequest pagedDataRequest,
            List<TModel> itemMapped
            )
        {
            var response = new PagedDataInquiryResponse<TModel>
            {
                Items = itemMapped,
                PageCount = queryResult.TotalPageCount,
                PageNumber = pagedDataRequest.PageNumber,
                PageSize = pagedDataRequest.PageSize,
                TotalCount = queryResult.TotalItemCount,
            };
            return response;
        }
    }
}