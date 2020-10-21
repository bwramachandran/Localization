using LocalizationTools.Model.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LocalizationTools.Data.RDB.Functions
{
    public partial class Function
    {
        public List<GetConversationLineChildren> Udf_GetConversationLineChildren(int resourceVersionId, int stringId)
        {
            var list = new List<GetConversationLineChildren>();
            using SqlConnection con = new SqlConnection(m_connectionString);
            using SqlCommand cmd = new SqlCommand("select * from [dbo].[udf_GetConversationLineChildren] (@resourceVersionId, @stringId)", con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@resourceVersionId", resourceVersionId);
            cmd.Parameters.AddWithValue("@stringId", stringId);
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    GetConversationLineChildren result = new GetConversationLineChildren();
                    result.IsSoftLink = (bool)reader["IsSoftLink"];
                    result.StringId = (int)reader["StringID"];
                    list.Add(result);
                    //result.ParaphraseStringId = (int)reader["ParaphraseStringID"];
                }
            }
            con.Close();
            return list;
        }
    }
}
