using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TApiRequest
    {
        public int ApiRequestId { get; set; }
        public DateTime AccessedOnUtc { get; set; }
        public string Class { get; set; }
        public string Method { get; set; }
        public string Arguments { get; set; }
        public string AuthenticationType { get; set; }
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientHostName { get; set; }
        public string ServerName { get; set; }
        public bool AccessPermitted { get; set; }
        public string RequestPath { get; set; }
        public string Url { get; set; }
        public string QueryString { get; set; }
    }
}
