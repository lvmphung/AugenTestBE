using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AugenProject.Web.Common.ActionHelper
{
    public class ActionResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public int ErrorCode { get; set; }
    }
}