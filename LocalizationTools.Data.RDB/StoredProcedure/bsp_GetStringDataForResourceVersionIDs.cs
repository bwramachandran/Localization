using LocalizationTools.Model.DTO;
using Microsoft.AspNetCore.Connections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace LocalizationTools.Data.RDB.StoredProcedure
{
    public class bsp_GetStringDataForResourceVersionIDs
    {
        //public Attributes GetStringDataForResourceVersionIDs(int resourceVersionId)
        //{
        //    var attributes = new Attributes();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    DataTable table = new DataTable();
        //    table.Columns.Add("ResourceVersionId", typeof(int));
        //    table.Rows.Add(resourceVersionId);
        //    using SqlCommand cmd = new SqlCommand("[dbo].[bsp_GetStringDataForResourceVersionIDs]", con)
        //    {
        //        CommandType = CommandType.StoredProcedure
        //    };
        //    cmd.Parameters.AddWithValue("@resourceVersionIDs", table);
        //    con.Open();
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            StringDataForResourceVersionID stringDataForResourceVersionID = new StringDataForResourceVersionID
        //            {
        //                StringId = (int)reader["StringId"],
        //                FriendlyStringId = (int)reader["FriendlyStringId"],
        //                StringTypeId = (int)reader["StringTypeId"],
        //                Text = (string)reader["Text"],
        //                WordCount = (int)reader["WordCount"],
        //                IsTranslationEligible = (bool)reader["IsTranslationEligible"],
        //                LocalizedVersionId = (int)reader["LocalizedVersionId"],
        //                MaxCharacterLength = (int)reader["MaxCharacterLength"],
        //                TimingRestriction = (TimeConstraint)reader["TimingRestriction"],
        //                VOComment = (string)reader["VOComment"],
        //                EditorComment = (string)reader["EditorComment"],
        //                ListenerCharacterResourceID = Convert.IsDBNull(reader["ListenerCharacterResourceID"]) ? null : (int?)reader["ListenerCharacterResourceID"]
        //            };
        //            attributes.stringDataForResourceVersionID.Add(stringDataForResourceVersionID);
        //        }
        //        reader.NextResult();
        //        while (reader.Read())
        //        {
        //            StringSpeakerCharacter stringSpeakerCharacter = new StringSpeakerCharacter()
        //            {
        //                CharacterResourceId = (int)reader["CharacterResourceId"],
        //                IsVOEligible = (bool)reader["IsVOEligible"],
        //                IsVOReRecord = (bool)reader["IsVOReRecord"],
        //                VORequestOnUTC = (DateTime)reader["VORequestOnUTC"],
        //                VORequestResourceVersionId = (int)reader["VORequestResourceVersionId"]
        //            };
        //            attributes.stringSpeakerCharacter.Add(stringSpeakerCharacter);
        //        }
        //        reader.NextResult();
        //        while (reader.Read())
        //        {
        //            GrammarInfo grammarInfo = new GrammarInfo()
        //            {
        //                StringId = (int)reader["StringID"],
        //                ModifierPositionId = (int)reader["ModifierPositionId"],
        //                PhraseTemplateId = (int)reader["PhraseTemplateId"],
        //                PhraseElementId = (int)reader["PhraseElementId"],
        //                WordClassId = (int)reader["WordClassId"]
        //            };
        //            attributes.GrammarInfo.Add(grammarInfo);
        //        }
        //    }
        //    return attributes;
        //}
        
        //public GetStringExportStatusAndInfo GetStringExportStatusAndInfo(int stringId = 88833, int branchId = 7)
        //{
        //    GetStringExportStatusAndInfo result = new GetStringExportStatusAndInfo();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    DataTable table = new DataTable();
        //    table.Columns.Add("stringId", typeof(int));
        //    table.Rows.Add(stringId);
        //    using SqlCommand cmd = new SqlCommand("[loc].[bsp_GetStringExportStatusAndInfo]", con)
        //    {
        //        CommandType = CommandType.StoredProcedure
        //    };
        //    cmd.Parameters.AddWithValue("@branchId", branchId);
        //    cmd.Parameters.AddWithValue("@sinceUTC", SqlDateTime.Null);
        //    cmd.Parameters.AddWithValue("@stringIds", table);
        //    cmd.Parameters.AddWithValue("@isLocalizationReady ", null);
        //    con.Open();
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            result.IsClone = (bool)reader["IsClone"];
        //            result.SourceStringId = Convert.IsDBNull(reader["SourceStringID"]) ? null : (int?)reader["SourceStringID"];
        //        }
        //    }
        //    con.Close();
        //    return result;
        //}
        //public EnglishStringListDto StringExportStatusAndInfos(bool isLocalizationReady, DateTime? sinceUTC, int stringId, int branchId)
        //{
        //    EnglishStringListDto result = new EnglishStringListDto();
        //    using SqlConnection con = new SqlConnection("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
        //    DataTable table = new DataTable();
        //    table.Columns.Add("stringId", typeof(int));
        //    table.Rows.Add(stringId);
        //    using SqlCommand cmd = new SqlCommand("[loc].[bsp_GetStringExportStatusAndInfo]", con)
        //    {
        //        CommandType = CommandType.StoredProcedure
        //    };
        //    cmd.Parameters.AddWithValue("@branchId", branchId);
        //    cmd.Parameters.AddWithValue("@sinceUTC", sinceUTC ?? SqlDateTime.Null);
        //    cmd.Parameters.AddWithValue("@stringIds", table);
        //    cmd.Parameters.AddWithValue("@isLocalizationReady ", null);
        //    con.Open();
        //    using (SqlDataReader reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            result.BranchId = branchId;
        //            result.WordCount = (int)reader["WordCount"];
        //            result.StringId = (int)reader["StringId"];
        //            result.LocalizedVersionId = (int)reader["LocalizedVersionId"];
        //            result.ProjectResourceUniqueId = (string)reader["ProjectResourceUniqueId"];
        //            //result.ModificationDate = Convert.IsDBNull(reader["ModificationDate"]) ? null : (DateTime)reader["ModificationDate"];
        //            result.VoComment = (string)reader["VoComment"];
        //            result.EditorComment = (string)reader["EditorComment"];
        //            result.ProductionStatus = (string)reader["ProductionState"];
        //            result.IsLocalizationReady = (bool)reader["IsLocalizationReady"];
        //            result.TimingRestriction = (int)reader["TimingRestriction"];
        //            result.ResourceId = (int)reader["ResourceId"];
        //            result.ResourceVersionId = (int)reader["ResourceVersionId"];
        //        }
        //    }
        //    con.Close();
        //    return result;
        //}
    }
}
