using System;
using System.Collections.Generic;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class TUserLog
    {
        public int UserLogId { get; set; }
        public string UserName { get; set; }
        public DateTime LoggedOnUtc { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationSession { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string StackTrace { get; set; }
    }
}
