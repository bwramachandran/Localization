using LocalizationTools.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;

namespace LocalizationTools.Data.RDB.Functions
{
    public partial class Function 
    {
        public List<RemovedStringDto> Udf_GetRemovedStrings(int branchId, DateTime? sinceUTC)
        {
            List <RemovedStringDto> returnList = new List<RemovedStringDto>();
            using SqlConnection con = new SqlConnection(m_connectionString);
            using SqlCommand cmd = new SqlCommand("select * from [dbo].[udf_GetRemovedStrings] (@branchId, @sinceUTC)", con)
            {
                CommandType = CommandType.Text
            };
            con.Open();
            cmd.Parameters.AddWithValue("@branchId", branchId);
            cmd.Parameters.AddWithValue("@sinceUTC", SqlDateTime.Null);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    RemovedStringDto result = new RemovedStringDto
                    {
                        RemovalTypeId = (int)reader["RemovalTypeID"],
                        StringId = (int)reader["StringId"]
                    };
                    returnList.Add(result);
                }
            }
            return returnList;
        }
    }
}
