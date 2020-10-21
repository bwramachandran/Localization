using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class VWebApiAccess
    {
        public DateTime AccessedOnUtc { get; set; }
        public string UserName { get; set; }
        public string ClientAddress { get; set; }
        public bool AccessPermitted { get; set; }
        public string RequestPath { get; set; }
        public string QueryString { get; set; }
        public string Url { get; set; }
    }
}
