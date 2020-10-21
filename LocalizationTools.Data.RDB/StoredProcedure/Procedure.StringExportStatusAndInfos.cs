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
        public EnglishStringListDto StringExportStatusAndInfos(bool isLocalizationReady, DateTime? sinceUTC, int stringId, int branchId)
        {
            EnglishStringListDto result = new EnglishStringListDto();
            using SqlConnection con = new SqlConnection(m_connectionString);
            DataTable table = new DataTable();
            table.Columns.Add("stringId", typeof(int));
            table.Rows.Add(stringId);
            using SqlCommand cmd = new SqlCommand("[loc].[bsp_GetStringExportStatusAndInfo]", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@branchId", branchId);
            cmd.Parameters.AddWithValue("@sinceUTC", sinceUTC ?? SqlDateTime.Null);
            cmd.Parameters.AddWithValue("@stringIds", table);
            cmd.Parameters.AddWithValue("@isLocalizationReady ", isLocalizationReady);
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.BranchId = branchId;
                    result.WordCount = (int)reader["WordCount"];
                    result.StringId = (int)reader["StringId"];
                    result.LocalizedVersionId = (int)reader["LocalizedVersionId"];
                    result.ProjectResourceUniqueId = (string)reader["ProjectResourceUniqueId"];
                    //result.ModificationDate = Convert.IsDBNull(reader["ModificationDate"]) ? null : (DateTime)reader["ModificationDate"];
                    result.VoComment = (string)reader["VoComment"];
                    result.EditorComment = (string)reader["EditorComment"];
                    result.ProductionStatus = (string)reader["ProductionState"];
                    result.IsLocalizationReady = (bool)reader["IsLocalizationReady"];
                    result.TimingRestriction = (int)reader["TimingRestriction"];
                    result.ResourceId = (int)reader["ResourceId"];
                    result.ResourceVersionId = (int)reader["ResourceVersionId"];
                    result.IsClone = (bool)reader["IsClone"];
                    result.SourceStringId = Convert.IsDBNull(reader["SourceStringID"]) ? null : (int?)reader["SourceStringID"];
                }
            }
            con.Close();
            return result;
        }
    }
}
