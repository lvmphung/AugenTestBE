using AugenProject.Common;
using AugenProject.Services.Models.Customers;
using AugenProject.Web.Api.IntegrationTests.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AugenProject.Web.Api.IntegrationTests.Controller
{
    [TestClass]
    public class CustomersControllerTest : IntegrationTest
    {
        [TestMethod]
        public void GetAllCustomers_ShouldReturnAllCustomers()
        {
            var address = string.Format(CommonService.GetCustomers, UriRoot);
            var headers = new WebHeaderCollection
            {
                {"Accept-Charset", "UTF-8"},
            };

            var getResponseString = ClientRequestHelper.SendRequest(headers, address, Constants.HttpMethodNames.Get);
            var actionResult = ResponseExtension.ValidateSucceedResponse(getResponseString);
            //assert
            Assert.IsNotNull(actionResult.Data);
        }
    }
}
