using AugenProject.Web.Api.Controllers.v1.Interfaces;
using System.Net.Http;
using System.Web.Http;

namespace AugenProject.Web.Api.Controllers.v1
{
    public class CustomersController : ApiControllerBase<ICustomersControllerDependencyBlock>
    {
        public CustomersController(ICustomersControllerDependencyBlock settingsControllerDependencyBlock)
            : base(settingsControllerDependencyBlock)
        {
        }

        /// <summary>
        ///  1.1 api/v1/customers
        /// PHUNG LE, 2019-09-27, get all customers
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <returns></returns>
        [Route("api/v1/customers", Name = "GetCustomers")]
        [HttpGet]
        public IHttpActionResult GetCustomers(HttpRequestMessage requestMessage)
        {
            var customers = _controllerDependency.CustomersProcessor.GetCustomers();
            return WrapApiActionResult(requestMessage, true, customers);
        }
    }
}