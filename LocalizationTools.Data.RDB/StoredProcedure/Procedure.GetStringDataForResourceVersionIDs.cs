using LocalizationTools.Model.DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LocalizationTools.Data.RDB.StoredProcedure
{
    public partial class Procedure
    {
        public Attributes GetStringDataForResourceVersionIDs(int resourceVersionId)
        {
            var attributes = new Attributes();
            using SqlConnection con = new SqlConnection(m_connectionString);
            DataTable table = new DataTable();
            table.Columns.Add("ResourceVersionId", typeof(int));
            table.Rows.Add(resourceVersionId);
            using SqlCommand cmd = new SqlCommand("[dbo].[bsp_GetStringDataForResourceVersionIDs]", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@resourceVersionIDs", table);
            con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    StringDataForResourceVersionID stringDataForResourceVersionID = new StringDataForResourceVersionID
                    {
                        StringId = (int)reader["StringId"],
                        FriendlyStringId = (int)reader["FriendlyStringId"],
                        StringTypeId = (int)reader["StringTypeId"],
                        Text = (string)reader["Text"],
                        WordCount = (int)reader["WordCount"],
                        IsTranslationEligible = (bool)reader["IsTranslationEligible"],
                        LocalizedVersionId = (int)reader["LocalizedVersionId"],
                        MaxCharacterLength = (int)reader["MaxCharacterLength"],
                        TimingRestriction = (TimeConstraint)reader["TimingRestriction"],
                        VOComment = (string)reader["VOComment"],
                        EditorComment = (string)reader["EditorComment"],
                        //StringTypeName = (string) reader["StringTypeName"]
                        ListenerCharacterResourceID = Convert.IsDBNull(reader["ListenerCharacterResourceID"]) ? null : (int?)reader["ListenerCharacterResourceID"],
                        //RecordingTypeName = (string)reader["RecordingTypeName"]
                    };
                    attributes.stringDataForResourceVersionID.Add(stringDataForResourceVersionID);
                }
                reader.NextResult();
                while (reader.Read())
                {
                    StringSpeakerCharacter stringSpeakerCharacter = new StringSpeakerCharacter()
                    {
                        CharacterResourceId = (int)reader["CharacterResourceId"],
                        IsVOEligible = (bool)reader["IsVOEligible"],
                        IsVOReRecord = (bool)reader["IsVOReRecord"],
                        VORequestOnUTC = (DateTime)reader["VORequestOnUTC"],
                        VORequestResourceVersionId = (int)reader["VORequestResourceVersionId"]
                    };
                    attributes.stringSpeakerCharacter.Add(stringSpeakerCharacter);
                }
                reader.NextResult();
                while (reader.Read())
                {
                    GrammarInfo grammarInfo = new GrammarInfo()
                    {
                        StringId = (int)reader["StringID"],
                        ModifierPositionId = (int)reader["ModifierPositionId"],
                        PhraseTemplateId = (int)reader["PhraseTemplateId"],
                        PhraseElementId = (int)reader["PhraseElementId"],
                        WordClassId = (int)reader["WordClassId"]
                    };
                    attributes.GrammarInfo.Add(grammarInfo);
                }
            }
            return attributes;
        }
    }
}
