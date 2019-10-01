using AugenProject.Common;
using AugenProject.Common.Serialization;
using AugenProject.Web.Common;

namespace AugenProject.Web.Api.IntegrationTests
{
    public class IntegrationTest
    {
        public const string UriRoot = Constants.ApiURLValues.LocalHost;
        protected readonly ClientRequestHelper ClientRequestHelper = new ClientRequestHelper();
        protected SerializationHelper SerializationHelper = new SerializationHelper();
        public static class CommonService
        {
            public const string GetCustomers = "{0}/api/v1/customers";
        }
    }
}
