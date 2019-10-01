using AugenProject.Common.Serialization;
using AugenProject.Web.Common.ActionHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AugenProject.Web.Api.IntegrationTests.Extensions
{
    public static class ResponseExtension
    {
        /// <summary>
        /// Get Action Result from service response
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static ActionResult GetActionResult(this string response)
        {
            if (String.IsNullOrEmpty(response))
                throw new ArgumentNullException("Cannot get object from null response");

            var serializer = new SerializationHelper();
            var actionResult = serializer.DeserializeJsonToObject<ActionResult>(response);
            return actionResult;
        }

        public static ActionResult ValidateSucceedResponse(string response)
        {
            // Check response
            Assert.IsNotNull(response);

            // Check action result
            var actionResult = response.GetActionResult();
            Assert.IsNotNull(actionResult, actionResult.Message);
            Assert.IsTrue(actionResult.Success, actionResult.Message);
            Assert.IsTrue(actionResult.ErrorCode == 0, actionResult.Message);
            return actionResult;
        }

        public static ActionResult ValidateFailedResponse(string response)
        {
            // Check response
            Assert.IsNotNull(response);

            // Check action result
            var actionResult = response.GetActionResult();
            Assert.IsNotNull(actionResult);
            Assert.IsTrue(!actionResult.Success);
            Assert.IsTrue(actionResult.ErrorCode != 0);
            return actionResult;
        }
    }
}
