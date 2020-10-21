using LocalizationTools.Data.RDB.Functions;
using LocalizationTools.Data.RDB.Models;
using LocalizationTools.Data.RDB.StoredProcedure;
using Microsoft.Extensions.Logging;

namespace LocalizationTools.Data.LocAPI
{
    public partial class DataServiceLocAPI 
    {
        private readonly bw_loc_dylan_devContext m_dbContext;
        private readonly IFunction m_functionService;
        private readonly IProcedure m_procedureService;
        private readonly ILogger<DataServiceLocAPI> m_loggerService;

        public DataServiceLocAPI(bw_loc_dylan_devContext dbContext,
                                         IFunction function, 
                                         IProcedure procedure,
                                         ILogger<DataServiceLocAPI> logger
                                )
        {
            m_dbContext = dbContext;
            m_functionService = function;
            m_procedureService = procedure;
            m_loggerService = logger;
        }
    }
}
