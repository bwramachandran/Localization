using LocalizationTools.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace LocalizationTools.Data.RDB.Functions
{
    public partial class Function
    {
        public GetStringExportCloneStatus Udf_GetStringExportCloneStatus(int branchId, int translationPartnerId)
        {
            GetStringExportCloneStatus result = new GetStringExportCloneStatus();
            using SqlConnection con = new SqlConnection(m_connectionString);
            using SqlCommand cmd = new SqlCommand("select * from [loc].[udf_GetStringExportCloneStatus] (@branchId, @translationPartner)", con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@branchId", branchId);
            cmd.Parameters.AddWithValue("@translationPartner", translationPartnerId);
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.SourceStringId = (int)reader["SourceStringId"];
                }
            }
            con.Close();
            return result;
        }
    }
}
