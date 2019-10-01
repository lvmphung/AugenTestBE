namespace AugenProject.Web.Common.ActionHelper
{
    public class ActionResultHelper : IActionResultHelper
    {
        public ActionResult WrapActionResult(bool isSuccess, string message, object data)
        {
            return new ActionResult
            {
                Success = isSuccess,
                Message = message,
                Data = data,
            };
        }
    }
}