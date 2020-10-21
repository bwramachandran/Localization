using LocalizationTools.Data.RDB.Models;
using LocalizationTools.Model.DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationTools.Data.RDB.Functions
{
    public partial class Function : IFunction
    {
        private readonly bw_loc_dylan_devContext m_dbContext;
        private string m_connectionString;

        public Function(bw_loc_dylan_devContext dbContext, IConfiguration configuration)
        {
            m_dbContext = dbContext;
            m_connectionString = configuration.GetSection("ConnectionStrings:bwloctools").Value;
        }
    }
}
