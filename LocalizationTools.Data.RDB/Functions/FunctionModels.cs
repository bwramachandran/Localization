using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Data.SqlClient;
using LocalizationTools.Model.DTO;
using System.Data;
using Castle.Core.Internal;
using System.Data.SqlTypes;

namespace LocalizationTools.Data.RDB.Functions
{
    public class FunctionModels
    {
        //public GetRawForeignVOForecastingData udf_GetRawForeignVOForecastingData()
        //{
        //    GetRawForeignVOForecastingData data = new GetRawForeignVOForecastingData();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    using SqlCommand cmd = new SqlCommand("select * from [dbo].[udf_GetRawForeignVOForecastingData]", con)
        //    {
        //        CommandType = CommandType.Text
        //    };
        //    con.Open();
        //    cmd.Parameters.AddWithValue("", null);
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            data.RequiresTranslation = (bool)reader["RequiresTranslation"];
        //        }
        //    }
        //    return data;
        //}

        public StringExportStatus udf_GetStringExportStatus(int branchId, int translationPartnerId, int resourceId, DateTime modifiedTime)
        {
            StringExportStatus res = new StringExportStatus();
            using SqlConnection con = new SqlConnection("Server = bwe-sqlsupport1; Database = bw_loc_dylan_dev; Trusted_Connection = True;");
            using SqlCommand cmd = new SqlCommand("select * from [loc].[udf_GetStringExportStatus] (@branchID, @translationPartnerID, @resourceID, @snapshotTimeUTC)", con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@branchID", 7);
            cmd.Parameters.AddWithValue("@translationPartnerID", 1);
            cmd.Parameters.AddWithValue("@resourceID", 24026);
            cmd.Parameters.AddWithValue("@snapshotTimeUTC", DateTime.Now);
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    res.StringId = (int)reader["StringId"];
                    res.RequiresNewTranslation = (bool)reader["RequiresNewTranslation"];
                    res.RequiresMajorTranslation = (bool)reader["RequiresMajorTranslation"];
                    res.RequiresMinorTranslation = (bool)reader["RequiresMinorTranslation"];
                    res.IsLocalizationReady = (bool)reader["IsLocalizationReady"];
                    res.WordCount = (int)reader["WordCount"];
                    res.ResourceId = (int)reader["ResourceId"];
                    res.ResourceVersionId = (int)reader["ResourceVersionId"];
                    res.ModuleId = (int)reader["ModuleId"];
                    res.StringTypeId = (int)reader["StringTypeId"];
                    res.IsGrammar = (bool)reader["IsGrammar"];
                    //res.WordClassId = (int)reader["WordClassId"];
                    res.WordCount = (int)reader["WordCount"];
                    //res.PhraseElementId = (int)reader["PhraseElementId"];
                    //res.PhraseTemplateId = (int)reader["PhraseTemplateId"];
                    res.LocalizedVersionId = (int)reader["LocalizedVersionId"];
                }
            }
            con.Close();
            res.TranslationRequirement = RequiresTranslation.None;
            if (res.RequiresNewTranslation)
            {
                res.TranslationRequirement = RequiresTranslation.New;
            }
            if (res.RequiresMajorTranslation)
            {
                res.TranslationRequirement = RequiresTranslation.Major;
            }
            if (res.RequiresMinorTranslation)
            {
                res.TranslationRequirement = RequiresTranslation.Minor;
            }
            return res;
        }
        //public ResourceString udf_GetResourceInformationForResourceVersionIDs(int resourceVersionId = 8)
        //{
        //    ResourceString result = new ResourceString();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    using SqlCommand cmd = new SqlCommand("DECLARE @resourceVersionIDs utt_KeyedIntList"+ " INSERT @resourceVersionIDs"+
        //                                " select "+resourceVersionId+
        //                                " select * from [dbo].[udf_GetResourceInformationForResourceVersionIDs] (@resourceVersionIDs)", con)
        //    {
        //        CommandType = CommandType.Text
        //    };
        //    con.Open();
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            result.ResourceID = (int)reader["ResourceID"];
        //            result.BranchID = (int)reader["BranchID"];
        //            result.Status = (string)reader["Status"];
        //            result.Folder = (string)reader["Folder"];
        //            result.Name = (string)reader["Name"];
        //            result.FullName = (string)reader["FullName"];
        //            result.ResourceTypeID = (int)reader["ResourceTypeID"];
        //            result.RepositoryPath = (string)reader["RepositoryPath"];
        //            result.ProjectVersion = (int)reader["ProjectVersion"];
        //            result.DataImportSessionID = (int)reader["DataImportSessionID"];
        //            result.ChangelistID = (int)reader["ChangelistID"];
        //            result.ModuleID = (int)reader["ModuleID"];
        //            result.WritingWorkflowStateID = (int)reader["WritingWorkflowStateID"];
        //            result.ProductionStateID = (int)reader["ProductionStateID"];
        //            result.ModelTypeID = (int)reader["ModelTypeID"];
        //            result.ResourceUniqueID = (string)reader["ResourceUniqueID"];
        //            result.ScopeTag = reader.IsNullOrEmpty()? string.Empty :  (string)reader["ScopeTag"];
        //            result.ScopeSubTag = reader.IsNullOrEmpty()? string.Empty : (string)reader["ScopeSubTag"];
        //            //result.TypeTag = (int)reader["TypeTag"];
        //            //result.WritingPointOfContact = (string)reader["WritingPointOfContact"];
        //        }
        //    }
        //    con.Close();
        //    return result;
        //}

        public StringOwnerInformation udf_GetStringOwnerInformation()
        {
            StringOwnerInformation stringOwnerInformation = new StringOwnerInformation();
            using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
            using SqlCommand cmd = new SqlCommand("select * from [dbo].[udf_GetStringOwnerInformation] (@branchID, @moduleID, @resourceID, @snapshotTimeUTC)", con)
            {
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@branchID", 7);
            cmd.Parameters.AddWithValue("@moduleID",1);
            cmd.Parameters.AddWithValue("@resourceID",null);
            cmd.Parameters.AddWithValue("@snapshotTimeUTC",null);
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    stringOwnerInformation.ResourceId = (int)reader["ResourceId"];
                    stringOwnerInformation.ResourceVersionID = (int)reader["ResourceVersionID"];
                    stringOwnerInformation.StringId = (int)reader["StringId"];
                    stringOwnerInformation.StringTypeID = (int)reader["StringTypeID"];
                }
            }
            con.Close();
            return stringOwnerInformation;
        }
        //public Speakers udf_GetResourceVersionStringListener(int resourceVersionId=22, int stringId=262)
        //{
        //    Speakers result = new Speakers();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    using SqlCommand cmd = new SqlCommand("select * from [dbo].[udf_GetResourceVersionStringListener] (@resourceVersionID, @stringID)", con)
        //    {
        //        CommandType = CommandType.Text
        //    };
        //    cmd.Parameters.AddWithValue("@resourceVersionID", 7);
        //    cmd.Parameters.AddWithValue("@stringID", 1);
        //    con.Open();
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            result.Age = (string)reader["Age"];
        //            result.Name = (string)reader["Name"];
        //            result.Gender = (string)reader["Gender"];
        //            result.IsPlayer = (bool)reader["IsPlayer"];
        //        }
        //    }
        //    con.Close();
        //    return result;
        //}
        //public GetStringExportCloneStatus udf_GetStringExportCloneStatus (int branchId=7, int translationPartnerId=1)
        //{
        //    GetStringExportCloneStatus result = new GetStringExportCloneStatus();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    using SqlCommand cmd = new SqlCommand("select * from [loc].[udf_GetStringExportCloneStatus] (@branchId, @translationPartner)", con)
        //    {
        //        CommandType = CommandType.Text
        //    };
        //    cmd.Parameters.AddWithValue("@branchId", branchId);
        //    cmd.Parameters.AddWithValue("@translationPartner", translationPartnerId);
        //    con.Open();
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            result.SourceStringId = (int)reader["SourceStringId"];
        //        }
        //    }
        //    con.Close();
        //    return result;
        //}
        //public GetConversationLineParent udf_GetConversationLineParent(int resourceVersionId = 8, int stringId = 202)
        //{
        //    GetConversationLineParent result = new GetConversationLineParent();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    using SqlCommand cmd = new SqlCommand("select * from [dbo].[udf_GetConversationLineParent] (@resourceVersionId, @stringId)", con)
        //    {
        //        CommandType = CommandType.Text
        //    };
        //    cmd.Parameters.AddWithValue("@resourceVersionId", resourceVersionId);
        //    cmd.Parameters.AddWithValue("@stringId", stringId);
        //    con.Open();
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            result.IsSoftLink = (bool)reader["IsSoftLink"];
        //            result.StringId = (int)reader["StringID"];
        //        }
        //    }
        //    con.Close();
        //    return result;
        //}
        //public GetConversationLineChildren udf_GetConversationLineChildren(int resourceVersionId = 8, int stringId = 202)
        //{
        //    GetConversationLineChildren result = new GetConversationLineChildren();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    using SqlCommand cmd = new SqlCommand("select * from [dbo].[udf_GetConversationLineParent] (@resourceVersionId, @stringId)", con)
        //    {
        //        CommandType = CommandType.Text
        //    };
        //    cmd.Parameters.AddWithValue("@resourceVersionId", resourceVersionId);
        //    cmd.Parameters.AddWithValue("@stringId", stringId);
        //    con.Open();
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            result.IsSoftLink = (bool)reader["IsSoftLink"];
        //            result.StringId = (int)reader["StringID"];
        //            //result.ParaphraseStringId = (int)reader["ParaphraseStringID"];
        //        }
        //    }
        //    con.Close();
        //    return result;
        //}

        //public List<RemovedStringDto> udf_GetRemovedStrings(int branchId, DateTime? sinceUTC)
        //{
        //    List<RemovedStringDto> returnList = new List<RemovedStringDto>();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    using SqlCommand cmd = new SqlCommand("select * from [dbo].[udf_GetRemovedStrings] (@branchId, @sinceUTC)", con)
        //    {
        //        CommandType = CommandType.Text
        //    };
        //    con.Open();
        //    cmd.Parameters.AddWithValue("@branchId", branchId);
        //    cmd.Parameters.AddWithValue("@sinceUTC", SqlDateTime.Null);
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            RemovedStringDto result = new RemovedStringDto();
        //            result.RemovalTypeId = (int)reader["RemovalTypeID"];
        //            result.StringId = (int)reader["StringId"];
        //            returnList.Add(result);
        //        }
        //    }
        //    return returnList;
        //}

        //public DocumentContent GetDocumentContent(int resourceId)
        //{
        //    DocumentContent result = new DocumentContent();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    using SqlCommand cmd = new SqlCommand("select * from [dbo].[v_ResourceVersion] where resourceID= " + resourceId+"and status = 'C'", con)
        //    {
        //        CommandType = CommandType.Text
        //    };
        //    con.Open();
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            result.ResourceVersionId = (int)reader["ResourceVersionId"];
        //            result.ProductionStateId = (int)reader["ProductionStateId"];
        //            result.ResourceFolder = (string)reader["Folder"];
        //            result.ResourceName = (string)reader["Name"];
        //            result.ResourceTypeId = (int)reader["ResourceTypeID"];
        //            result.ScopeSubTag = Convert.IsDBNull(reader["ScopeSubTag"]) ? "NULL" : (string)reader["ScopeSubTag"];
        //            result.ScopeTag = Convert.IsDBNull(reader["ScopeTag"]) ? "NULL" : (string)reader["ScopeTag"];
        //            result.TypeTag = Convert.IsDBNull(reader["TypeTag"]) ? "NULL" : (string)reader["TypeTag"];
        //            result.WritingWorkFlowStatusId = Convert.IsDBNull(reader["WritingWorkFlowStateID"]) ? 0 : (int)reader["WritingWorkFlowStateID"];
        //        }
        //    }
        //    con.Close();
        //    return result;
        //}
    }
}
