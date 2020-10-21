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
        public DocumentContent GetDocumentContent(int resourceId)
        {
            DocumentContent result = new DocumentContent();
            using SqlConnection con = new SqlConnection(m_connectionString);
            using SqlCommand cmd = new SqlCommand("select * from [dbo].[v_ResourceVersion] where resourceID= " 
                                                        + resourceId + "and status = 'C'", con)
            {
                CommandType = CommandType.Text
            };
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.ResourceVersionId = (int)reader["ResourceVersionId"];
                    result.ProductionStateId = (int)reader["ProductionStateId"];
                    result.ResourceFolder = (string)reader["Folder"];
                    result.ResourceName = (string)reader["Name"];
                    result.ResourceTypeId = (int)reader["ResourceTypeID"];
                    result.ScopeSubTag = Convert.IsDBNull(reader["ScopeSubTag"]) ? "NULL" : (string)reader["ScopeSubTag"];
                    result.ScopeTag = Convert.IsDBNull(reader["ScopeTag"]) ? "NULL" : (string)reader["ScopeTag"];
                    result.TypeTag = Convert.IsDBNull(reader["TypeTag"]) ? "NULL" : (string)reader["TypeTag"];
                    result.WritingWorkFlowStatusId = Convert.IsDBNull(reader["WritingWorkFlowStateID"]) ? 0 : (int)reader["WritingWorkFlowStateID"];
                    result.ResourceInformation.Complexity = Convert.IsDBNull(reader["ComplexityName"]) ? "null" : (string)reader["ComplexityName"]; 
                    result.ResourceInformation.Synopsis = Convert.IsDBNull(reader["Synopsis"]) ? "null" : (string)reader["Synopsis"]; 
                }
            }
            con.Close();
            return result;
        }
    }
}
