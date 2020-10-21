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
        public Speakers Udf_GetResourceVersionStringListener(int resourceVersionId, int stringId)
        {
            Speakers result = new Speakers();
            using SqlConnection con = new SqlConnection(m_connectionString);
            using SqlCommand cmd = new SqlCommand("select * from [dbo].[udf_GetResourceVersionStringListener] (@resourceVersionID, @stringID)", con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@resourceVersionID", resourceVersionId);
            cmd.Parameters.AddWithValue("@stringID", stringId);
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Age = (string)reader["Age"];
                    result.Name = (string)reader["Name"];
                    result.Gender = (string)reader["Gender"];
                    result.IsPlayer = (bool)reader["IsPlayer"];
                }
            }
            con.Close();
            return result;
        }
    }
}
