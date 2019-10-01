using System.Net;

namespace AugenProject.Web.Common
{
    public interface IClientRequestHelper
    {
        string SendRequest(WebHeaderCollection headerCollection, string address, string method, string data = "");

    }
}
