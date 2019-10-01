using AugenProject.Common;
using System;
using System.Net;
using System.Text;

namespace AugenProject.Web.Common
{
    public class ClientRequestHelper : IClientRequestHelper
    {
        public string SendRequest(WebHeaderCollection headerCollection, string address, string method, string data = "")
        {
            if (headerCollection == null)
                throw new ArgumentNullException("HeaderCollection is null");
            using (var webClient = new WebClient())
            {
                webClient.Headers = headerCollection;
                if (method == Constants.HttpMethodNames.Get)
                    return webClient.DownloadString(new Uri(address));
                var bytes = Encoding.UTF8.GetBytes(data);
                var response = webClient.UploadData(address, method, bytes);
                return Encoding.Default.GetString(response);
            }
        }
    }
}