using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugenProject.Web.Common.ActionHelper
{
    public interface IActionResultHelper
    {
        ActionResult WrapActionResult(bool isSuccess, string message, object data);
    }
}
