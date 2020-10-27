using LocalizationTools.Data.RDB.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTools.Data.RDB.StoredProcedure
{
    public partial class Procedure : IProcedure
    {
        private string m_connectionString;
        public Procedure(IConfiguration configuration)
        {
            m_connectionString = configuration.GetSection("ConnectionStrings:bwloctools").Value;
        }
    }
}
