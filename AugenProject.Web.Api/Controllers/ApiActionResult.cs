using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace AugenProject.Web.Api.Controllers
{
    public class ApiActionResult : IHttpActionResult
    {
        private readonly HttpRequestMessage _requestMessage;
        public object Result { get; private set; }

        public ApiActionResult(HttpRequestMessage requestMessage, object result)
        {
            _requestMessage = requestMessage;
            Result = result;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute());
        }

        public HttpResponseMessage Execute()
        {
            var response = _requestMessage.CreateResponse(HttpStatusCode.OK, Result);
            return _requestMessage.CreateResponse(HttpStatusCode.OK, Result);
        }
    }
}