using LocalizationTools.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;

namespace LocalizationTools.Data.RDB.StoredProcedure
{
    public partial class Procedure
    {
        public GetStringExportStatusAndInfo GetStringExportStatusAndInfo(int stringId, int branchId)
        {
            GetStringExportStatusAndInfo result = new GetStringExportStatusAndInfo();
            using SqlConnection con = new SqlConnection(m_connectionString);
            DataTable table = new DataTable();
            table.Columns.Add("stringId", typeof(int));
            table.Rows.Add(stringId);
            using SqlCommand cmd = new SqlCommand("[loc].[bsp_GetStringExportStatusAndInfo]", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@branchId", branchId);
            cmd.Parameters.AddWithValue("@sinceUTC", SqlDateTime.Null);
            cmd.Parameters.AddWithValue("@stringIds", table);
            cmd.Parameters.AddWithValue("@isLocalizationReady ", null);
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.IsClone = (bool)reader["IsClone"];
                    result.SourceStringId = Convert.IsDBNull(reader["SourceStringID"]) ? null : (int?)reader["SourceStringID"];
                }
            }
            con.Close();
            return result;
        }
    }
}
