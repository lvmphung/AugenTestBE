using AugenProject.Web.Api.Controllers.v1.Interfaces;
using AugenProject.Web.Common.ActionHelper;
using System.Net.Http;
using System.Web.Http;

namespace AugenProject.Web.Api.Controllers
{
    public abstract class ApiControllerBase<T> : ApiController where T : IControllerDependencyBlock
    {
        protected T _controllerDependency;

        public ApiControllerBase(T controllerDependency)
        {
            _controllerDependency = controllerDependency;
        }
        protected ApiActionResult WrapApiActionResult<T>(HttpRequestMessage requestMessage
            , bool isSuccess
            , T data
            , string message = "")
        {
            var actionResult = _controllerDependency.ActionResultHelper
                .WrapActionResult(isSuccess, message, data);
            return new ApiActionResult(requestMessage, actionResult);
        }

        //protected ApiActionResult WrapApiActionResult<T>(HttpRequestMessage requestMessage
        //    , bool isSuccess
        //    , PagedDataInquiryResponse<T> paging
        //    , Action<dynamic> customize
        //    , string message = "")
        //{
        //    if (paging == null)
        //        throw new NullReferenceException("Paging agrument have not null");
        //    if (customize == null)
        //        throw new NullReferenceException("Customize agrument have not null");
        //    dynamic data = new DynamicDictionary();
        //    data.MaxId = paging.MaxId;
        //    data.TotalCount = paging.TotalCount;
        //    data.PageCount = paging.PageCount;
        //    data.PageSize = paging.PageSize;
        //    data.PageNumber = paging.PageNumber;
        //    customize(data);
        //    var actionResult = _controllerDependency.ActionResultHelper
        //        .WrapActionResult(isSuccess, message, data.Parse());
        //    return new ApiActionResult(requestMessage, actionResult);
        //}
    }
}