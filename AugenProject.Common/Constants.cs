using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AugenProject.Common
{
    public class Constants
    {
        public static class CommonParameterNames
        {
            public const string PageNumber = "pageNumber";
            public const string PageSize = "pageSize";
            public const string TotalItemCount = "totalItemCount";
        }

        public static class ApiURLValues
        {
            public const string LocalHost = "https://localhost:44340";
            //public const string LocalHostIIS = "http://localhost:8084/";
            //public const string Staging = "http://52.208.5.170:8080";
            //public const string LoadTest = "http://52.51.142.87";
            //public const string StagingWeb = "http://52.208.5.170";
            //public const string ProductionWeb = "https://meetatclick.com";
            //public const string AmazonS3Root = "";
        }

        public static class HttpMethodNames
        {
            public const string Post = "POST";
            public const string Get = "GET";
            public const string Put = "PUT";
            public const string Delete = "DELETE";
        }
    }
}