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
        public List<GetConversationLineParent> Udf_GetConversationLineParent(int resourceVersionId, int stringId)
        {
            List<GetConversationLineParent> list = new List<GetConversationLineParent>();
            using SqlConnection con = new SqlConnection(m_connectionString);
            using SqlCommand cmd = new SqlCommand("select * from [dbo].[udf_GetConversationLineParent] (@resourceVersionId, @stringId)", con)
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
                    GetConversationLineParent result = new GetConversationLineParent
                    {
                        IsSoftLink = (bool)reader["IsSoftLink"],
                        StringId = (int)reader["StringID"]
                    };
                    list.Add(result);
                }
            }
            con.Close();
            return list;
        }
    }
}
