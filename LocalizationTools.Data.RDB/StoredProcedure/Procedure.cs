using LocalizationTools.Data.RDB.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTools.Data.RDB.StoredProcedure
{
    public partial class Procedure : IProcedure
    {
        private readonly bw_loc_dylan_devContext m_dbContext;
        private string m_connectionString;
        public Procedure(bw_loc_dylan_devContext dbContext, IConfiguration configuration)
        {
            m_dbContext = dbContext;
            m_connectionString = configuration.GetSection("ConnectionStrings:bwloctools").Value;
        }
    }
}
