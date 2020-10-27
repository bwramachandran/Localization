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
        private string m_connectionString;

        public Function(IConfiguration configuration)
        {
            m_connectionString = configuration.GetSection("ConnectionStrings:bwloctools").Value;
        }
    }
}
