using Castle.Core.Internal;
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
        public ResourceString Udf_GetResourceInformationForResourceVersionIDs(int resourceVersionId)
        {
            ResourceString result = new ResourceString();
            using SqlConnection con = new SqlConnection(m_connectionString);
            using SqlCommand cmd = new SqlCommand("DECLARE @resourceVersionIDs utt_KeyedIntList" + 
                                        " INSERT @resourceVersionIDs" +
                                        " select " + resourceVersionId +
                                        " select * from [dbo].[udf_GetResourceInformationForResourceVersionIDs] (@resourceVersionIDs)", con)
            {
                CommandType = CommandType.Text
            };
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.ResourceID = (int)reader["ResourceID"];
                    result.BranchID = (int)reader["BranchID"];
                    result.Status = (string)reader["Status"];
                    result.Folder = (string)reader["Folder"];
                    result.Name = (string)reader["Name"];
                    result.FullName = (string)reader["FullName"];
                    result.ResourceTypeID = (int)reader["ResourceTypeID"];
                    result.RepositoryPath = (string)reader["RepositoryPath"];
                    result.ProjectVersion = (int)reader["ProjectVersion"];
                    result.DataImportSessionID = (int)reader["DataImportSessionID"];
                    result.ChangelistID = (int)reader["ChangelistID"];
                    result.ModuleID = (int)reader["ModuleID"];
                    result.WritingWorkflowStateID = (int)reader["WritingWorkflowStateID"];
                    result.ProductionStateID = (int)reader["ProductionStateID"];
                    result.ModelTypeID = (int)reader["ModelTypeID"];
                    result.ResourceUniqueID = (string)reader["ResourceUniqueID"];
                    result.ScopeTag = reader.IsNullOrEmpty() ? string.Empty : (string)reader["ScopeTag"];
                    result.ScopeSubTag = reader.IsNullOrEmpty() ? string.Empty : (string)reader["ScopeSubTag"];
                    //result.TypeTag = (int)reader["TypeTag"];
                    //result.WritingPointOfContact = (string)reader["WritingPointOfContact"];
                }
            }
            con.Close();
            return result;
        }
    }
}
