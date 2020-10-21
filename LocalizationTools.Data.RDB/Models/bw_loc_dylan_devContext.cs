using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LocalizationTools.Data.RDB.Models
{
    public partial class bw_loc_dylan_devContext : DbContext
    {
        public bw_loc_dylan_devContext()
        {
        }

        public bw_loc_dylan_devContext(DbContextOptions<bw_loc_dylan_devContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TActor> TActor { get; set; }
        public virtual DbSet<TApiRequest> TApiRequest { get; set; }
        public virtual DbSet<TBranch> TBranch { get; set; }
        public virtual DbSet<TBranchPriority> TBranchPriority { get; set; }
        public virtual DbSet<TCaseInsensitiveName> TCaseInsensitiveName { get; set; }
        public virtual DbSet<TCastingRole> TCastingRole { get; set; }
        public virtual DbSet<TChangelist> TChangelist { get; set; }
        public virtual DbSet<TCharacter> TCharacter { get; set; }
        public virtual DbSet<TCharacterCasting> TCharacterCasting { get; set; }
        public virtual DbSet<TCharacterCastingActor> TCharacterCastingActor { get; set; }
        public virtual DbSet<TCharacterDeltaHistory> TCharacterDeltaHistory { get; set; }
        public virtual DbSet<TCharacterGender> TCharacterGender { get; set; }
        public virtual DbSet<TCharacterRace> TCharacterRace { get; set; }
        public virtual DbSet<TCharacterSubCharacter> TCharacterSubCharacter { get; set; }
        public virtual DbSet<TCharacterType> TCharacterType { get; set; }
        public virtual DbSet<TCharacterVoice> TCharacterVoice { get; set; }
        public virtual DbSet<TCloneVoscriptGenerationSession> TCloneVoscriptGenerationSession { get; set; }
        public virtual DbSet<TConversation> TConversation { get; set; }
        public virtual DbSet<TConversationExertionPalette> TConversationExertionPalette { get; set; }
        public virtual DbSet<TConversationLine> TConversationLine { get; set; }
        public virtual DbSet<TConversationLineTransition> TConversationLineTransition { get; set; }
        public virtual DbSet<TConversationType> TConversationType { get; set; }
        public virtual DbSet<TCurrentEnglishStringCache> TCurrentEnglishStringCache { get; set; }
        public virtual DbSet<TCurrentNonVoenglishStringCache> TCurrentNonVoenglishStringCache { get; set; }
        public virtual DbSet<TData> TData { get; set; }
        public virtual DbSet<TDataImportSession> TDataImportSession { get; set; }
        public virtual DbSet<TDataTag> TDataTag { get; set; }
        public virtual DbSet<TExportIntentLog> TExportIntentLog { get; set; }
        public virtual DbSet<TExportSession> TExportSession { get; set; }
        public virtual DbSet<TExportSessionInfo> TExportSessionInfo { get; set; }
        public virtual DbSet<TExportSessionString> TExportSessionString { get; set; }
        public virtual DbSet<TExportSessionStringHistory> TExportSessionStringHistory { get; set; }
        public virtual DbSet<TExportSessionStringOperation> TExportSessionStringOperation { get; set; }
        public virtual DbSet<TExportSessionType> TExportSessionType { get; set; }
        public virtual DbSet<TForeignVoforecastData> TForeignVoforecastData { get; set; }
        public virtual DbSet<TGenericEnumeration> TGenericEnumeration { get; set; }
        public virtual DbSet<TGlobalParameter> TGlobalParameter { get; set; }
        public virtual DbSet<TGrammarEnumeration> TGrammarEnumeration { get; set; }
        public virtual DbSet<TGrammarModifierPosition> TGrammarModifierPosition { get; set; }
        public virtual DbSet<TImportRecallHistory> TImportRecallHistory { get; set; }
        public virtual DbSet<TImportSession> TImportSession { get; set; }
        public virtual DbSet<TImportSessionStage> TImportSessionStage { get; set; }
        public virtual DbSet<TImportSessionStageString> TImportSessionStageString { get; set; }
        public virtual DbSet<TImportSessionStageStringGrammarText> TImportSessionStageStringGrammarText { get; set; }
        public virtual DbSet<TImportSessionString> TImportSessionString { get; set; }
        public virtual DbSet<TImportSessionStringGrammarText> TImportSessionStringGrammarText { get; set; }
        public virtual DbSet<TImportSessionStringPhoneticText> TImportSessionStringPhoneticText { get; set; }
        public virtual DbSet<TImportSessionStringRecallHistory> TImportSessionStringRecallHistory { get; set; }
        public virtual DbSet<TImportSessionStringText> TImportSessionStringText { get; set; }
        public virtual DbSet<TJournalNode> TJournalNode { get; set; }
        public virtual DbSet<TJournalNodeTransition> TJournalNodeTransition { get; set; }
        public virtual DbSet<TLanguage> TLanguage { get; set; }
        public virtual DbSet<TLanguageGrammar> TLanguageGrammar { get; set; }
        public virtual DbSet<TLanguageGrammarNounGender> TLanguageGrammarNounGender { get; set; }
        public virtual DbSet<TLanguageGrammarNounNumber> TLanguageGrammarNounNumber { get; set; }
        public virtual DbSet<TLanguageTag> TLanguageTag { get; set; }
        public virtual DbSet<TLanguageVariant> TLanguageVariant { get; set; }
        public virtual DbSet<TModelType> TModelType { get; set; }
        public virtual DbSet<TModule> TModule { get; set; }
        public virtual DbSet<TParaphraseCategory> TParaphraseCategory { get; set; }
        public virtual DbSet<TParaphraseCategoryType> TParaphraseCategoryType { get; set; }
        public virtual DbSet<TProductionState> TProductionState { get; set; }
        public virtual DbSet<TRecordingStatus> TRecordingStatus { get; set; }
        public virtual DbSet<TRecordingType> TRecordingType { get; set; }
        public virtual DbSet<TReducedScriptsCache> TReducedScriptsCache { get; set; }
        public virtual DbSet<TRepositoryPath> TRepositoryPath { get; set; }
        public virtual DbSet<TResource> TResource { get; set; }
        public virtual DbSet<TResourceHistory> TResourceHistory { get; set; }
        public virtual DbSet<TResourceName> TResourceName { get; set; }
        public virtual DbSet<TResourceType> TResourceType { get; set; }
        public virtual DbSet<TResourceVersion> TResourceVersion { get; set; }
        public virtual DbSet<TResourceVersionString> TResourceVersionString { get; set; }
        public virtual DbSet<TResourceVersionStringComment> TResourceVersionStringComment { get; set; }
        public virtual DbSet<TResourceVersionStringGrammar> TResourceVersionStringGrammar { get; set; }
        public virtual DbSet<TResourceVersionStringSpeaker> TResourceVersionStringSpeaker { get; set; }
        public virtual DbSet<TString> TString { get; set; }
        public virtual DbSet<TStringCloneEvent> TStringCloneEvent { get; set; }
        public virtual DbSet<TStringCloneTriage> TStringCloneTriage { get; set; }
        public virtual DbSet<TStringCloneTriageProfile> TStringCloneTriageProfile { get; set; }
        public virtual DbSet<TStringCloneTriageSession> TStringCloneTriageSession { get; set; }
        public virtual DbSet<TStringHistory> TStringHistory { get; set; }
        public virtual DbSet<TStringImportCache> TStringImportCache { get; set; }
        public virtual DbSet<TStringRemovalType> TStringRemovalType { get; set; }
        public virtual DbSet<TStringType> TStringType { get; set; }
        public virtual DbSet<TStringVoenum> TStringVoenum { get; set; }
        public virtual DbSet<TTranslationPartner> TTranslationPartner { get; set; }
        public virtual DbSet<TUniqueFeminineTranslation> TUniqueFeminineTranslation { get; set; }
        public virtual DbSet<TUserLog> TUserLog { get; set; }
        public virtual DbSet<TVariant> TVariant { get; set; }
        public virtual DbSet<TVoice> TVoice { get; set; }
        public virtual DbSet<TVoprepInstance> TVoprepInstance { get; set; }
        public virtual DbSet<TVoprepInstanceString> TVoprepInstanceString { get; set; }
        public virtual DbSet<TVoscript> TVoscript { get; set; }
        public virtual DbSet<TVoscriptCache> TVoscriptCache { get; set; }
        public virtual DbSet<TVoscriptCacheStringProcessingQueue> TVoscriptCacheStringProcessingQueue { get; set; }
        public virtual DbSet<TVoscriptGenerationSession> TVoscriptGenerationSession { get; set; }
        public virtual DbSet<TVoscriptInstance> TVoscriptInstance { get; set; }
        public virtual DbSet<TVoscriptInstanceString> TVoscriptInstanceString { get; set; }
        public virtual DbSet<TVoscriptInstanceStringTriage> TVoscriptInstanceStringTriage { get; set; }
        public virtual DbSet<TVoscriptTriageAction> TVoscriptTriageAction { get; set; }
        public virtual DbSet<TVosession> TVosession { get; set; }
        public virtual DbSet<TVosessionContactInfo> TVosessionContactInfo { get; set; }
        public virtual DbSet<TVosessionData> TVosessionData { get; set; }
        public virtual DbSet<TVosessionScript> TVosessionScript { get; set; }
        public virtual DbSet<TVostringData> TVostringData { get; set; }
        public virtual DbSet<TWordAndLineCountData> TWordAndLineCountData { get; set; }
        public virtual DbSet<TWritingWorkflowState> TWritingWorkflowState { get; set; }
        public virtual DbSet<VCharacterCasting> VCharacterCasting { get; set; }
        public virtual DbSet<VCharacterGenderRace> VCharacterGenderRace { get; set; }
        public virtual DbSet<VCharacterVolineCountsByDate> VCharacterVolineCountsByDate { get; set; }
        public virtual DbSet<VCurrentCharacterVoiceAssociation> VCurrentCharacterVoiceAssociation { get; set; }
        public virtual DbSet<VCurrentMainBranchMasterText> VCurrentMainBranchMasterText { get; set; }
        public virtual DbSet<VGrammarNounGender> VGrammarNounGender { get; set; }
        public virtual DbSet<VGrammarNounNumber> VGrammarNounNumber { get; set; }
        public virtual DbSet<VGrammarPhraseElement> VGrammarPhraseElement { get; set; }
        public virtual DbSet<VGrammarPhraseTemplate> VGrammarPhraseTemplate { get; set; }
        public virtual DbSet<VGrammarWordClass> VGrammarWordClass { get; set; }
        public virtual DbSet<VHighLevelExportProgressByConversationLines> VHighLevelExportProgressByConversationLines { get; set; }
        public virtual DbSet<VHighLevelExportProgressByConversationLinesAndWords> VHighLevelExportProgressByConversationLinesAndWords { get; set; }
        public virtual DbSet<VHighLevelExportProgressByConversationWords> VHighLevelExportProgressByConversationWords { get; set; }
        public virtual DbSet<VHighLevelExportProgressByLines> VHighLevelExportProgressByLines { get; set; }
        public virtual DbSet<VHighLevelExportProgressByLinesAndWords> VHighLevelExportProgressByLinesAndWords { get; set; }
        public virtual DbSet<VHighLevelExportProgressByNonConversationLines> VHighLevelExportProgressByNonConversationLines { get; set; }
        public virtual DbSet<VHighLevelExportProgressByNonConversationLinesAndWords> VHighLevelExportProgressByNonConversationLinesAndWords { get; set; }
        public virtual DbSet<VHighLevelExportProgressByNonConversationWords> VHighLevelExportProgressByNonConversationWords { get; set; }
        public virtual DbSet<VHighLevelExportProgressByWords> VHighLevelExportProgressByWords { get; set; }
        public virtual DbSet<VImportSessionText> VImportSessionText { get; set; }
        public virtual DbSet<VLocalizationImportProgressByConversationLines> VLocalizationImportProgressByConversationLines { get; set; }
        public virtual DbSet<VLocalizationImportProgressByConversationLinesAndWords> VLocalizationImportProgressByConversationLinesAndWords { get; set; }
        public virtual DbSet<VLocalizationImportProgressByConversationWords> VLocalizationImportProgressByConversationWords { get; set; }
        public virtual DbSet<VLocalizationImportProgressByLines> VLocalizationImportProgressByLines { get; set; }
        public virtual DbSet<VLocalizationImportProgressByLinesAndWords> VLocalizationImportProgressByLinesAndWords { get; set; }
        public virtual DbSet<VLocalizationImportProgressByNonConversationLines> VLocalizationImportProgressByNonConversationLines { get; set; }
        public virtual DbSet<VLocalizationImportProgressByNonConversationLinesAndWords> VLocalizationImportProgressByNonConversationLinesAndWords { get; set; }
        public virtual DbSet<VLocalizationImportProgressByNonConversationWords> VLocalizationImportProgressByNonConversationWords { get; set; }
        public virtual DbSet<VLocalizationImportProgressByWords> VLocalizationImportProgressByWords { get; set; }
        public virtual DbSet<VNonUniqueCharacterNames> VNonUniqueCharacterNames { get; set; }
        public virtual DbSet<VPrintedStringTextVersions> VPrintedStringTextVersions { get; set; }
        public virtual DbSet<VResourceVersion> VResourceVersion { get; set; }
        public virtual DbSet<VScopeByConversationType> VScopeByConversationType { get; set; }
        public virtual DbSet<VScopeByLineAverage> VScopeByLineAverage { get; set; }
        public virtual DbSet<VScopeByWritingWorkflow> VScopeByWritingWorkflow { get; set; }
        public virtual DbSet<VStringCloneTriageInformation> VStringCloneTriageInformation { get; set; }
        public virtual DbSet<VTranslationImportHistory> VTranslationImportHistory { get; set; }
        public virtual DbSet<VVoiceVolineCountsByDate> VVoiceVolineCountsByDate { get; set; }
        public virtual DbSet<VVoscriptInstanceStringText> VVoscriptInstanceStringText { get; set; }
        public virtual DbSet<VWebApiAccess> VWebApiAccess { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=bwe-sqlsupport1;Database=bw_loc_dylan_dev;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TActor>(entity =>
            {
                entity.HasKey(e => e.ActorId)
                    .HasName("PK__t_Actor__57B3EA2B405A880E");

                entity.ToTable("t_Actor", "vo");

                entity.Property(e => e.ActorId).HasColumnName("ActorID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<TApiRequest>(entity =>
            {
                entity.HasKey(e => e.ApiRequestId);

                entity.ToTable("t_ApiRequest", "log");

                entity.Property(e => e.ApiRequestId).HasColumnName("ApiRequestID");

                entity.Property(e => e.AccessedOnUtc)
                    .HasColumnName("AccessedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.AuthenticationType)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ClientAddress)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ClientHostName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.QueryString).IsRequired();

                entity.Property(e => e.RequestPath).IsRequired();

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Url).IsRequired();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TBranch>(entity =>
            {
                entity.HasKey(e => e.BranchId);

                entity.ToTable("t_Branch");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.PriorityId)
                    .HasColumnName("PriorityID")
                    .HasDefaultValueSql("((4))");
            });

            modelBuilder.Entity<TBranchPriority>(entity =>
            {
                entity.HasKey(e => e.PriorityId)
                    .HasName("PK__t_Branch__D0A3D0DE4FF1D159");

                entity.ToTable("t_BranchPriority");

                entity.Property(e => e.PriorityId)
                    .HasColumnName("PriorityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCaseInsensitiveName>(entity =>
            {
                entity.HasKey(e => e.CaseInsensitiveNameId);

                entity.ToTable("t_CaseInsensitiveName");

                entity.Property(e => e.CaseInsensitiveNameId).HasColumnName("CaseInsensitiveNameID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCastingRole>(entity =>
            {
                entity.HasKey(e => e.CastingRoleId);

                entity.ToTable("t_CastingRole", "vo");

                entity.Property(e => e.CastingRoleId).HasColumnName("CastingRoleID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<TChangelist>(entity =>
            {
                entity.HasKey(e => e.ChangelistId);

                entity.ToTable("t_Changelist");

                entity.Property(e => e.ChangelistId).HasColumnName("ChangelistID");

                entity.Property(e => e.ChangeComment)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ChangeId)
                    .IsRequired()
                    .HasColumnName("ChangeID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeRangeStartId)
                    .HasColumnName("ChangeRangeStartID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ContractProducerComment)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DataExporterProcessedOnUtc)
                    .HasColumnName("DataExporterProcessedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubmittedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedOnUtc)
                    .HasColumnName("SubmittedOnUTC")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TCharacter>(entity =>
            {
                entity.HasKey(e => e.ResourceVersionId);

                entity.ToTable("t_Character");

                entity.Property(e => e.ResourceVersionId)
                    .HasColumnName("ResourceVersionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accent).IsRequired();

                entity.Property(e => e.AgeRange).IsRequired();

                entity.Property(e => e.Appearance).IsRequired();

                entity.Property(e => e.Archetype).IsRequired();

                entity.Property(e => e.CharacterGenderId).HasColumnName("CharacterGenderID");

                entity.Property(e => e.CharacterRaceId).HasColumnName("CharacterRaceID");

                entity.Property(e => e.CharacterTypeId).HasColumnName("CharacterTypeID");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.IsVoeligible).HasColumnName("IsVOEligible");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.RelationshipToPlayer).IsRequired();

                entity.Property(e => e.TiesToOtherCharacters).IsRequired();

                entity.HasOne(d => d.CharacterGender)
                    .WithMany(p => p.TCharacter)
                    .HasForeignKey(d => d.CharacterGenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Character_CharacterGenderID");

                entity.HasOne(d => d.CharacterRace)
                    .WithMany(p => p.TCharacter)
                    .HasForeignKey(d => d.CharacterRaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Character_CharacterRaceID");

                entity.HasOne(d => d.CharacterType)
                    .WithMany(p => p.TCharacter)
                    .HasForeignKey(d => d.CharacterTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Character_CharacterTypeID");

                entity.HasOne(d => d.ResourceVersion)
                    .WithOne(p => p.TCharacter)
                    .HasForeignKey<TCharacter>(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Character_ResourceVersionID");
            });

            modelBuilder.Entity<TCharacterCasting>(entity =>
            {
                entity.HasKey(e => e.ResourceVersionId);

                entity.ToTable("t_CharacterCasting", "vo");

                entity.Property(e => e.ResourceVersionId)
                    .HasColumnName("ResourceVersionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CastingRoleId).HasColumnName("CastingRoleID");

                entity.Property(e => e.Comments).IsRequired();

                entity.Property(e => e.CurrentCastingActorId).HasColumnName("CurrentCastingActorID");

                entity.Property(e => e.VoiceResourceId).HasColumnName("VoiceResourceID");

                entity.HasOne(d => d.CastingRole)
                    .WithMany(p => p.TCharacterCasting)
                    .HasForeignKey(d => d.CastingRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_CharacterCasting_CastingRoleID");

                entity.HasOne(d => d.CurrentCastingActor)
                    .WithMany(p => p.TCharacterCasting)
                    .HasForeignKey(d => d.CurrentCastingActorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_CharacterCasting_CurrentCastingActorID");

                entity.HasOne(d => d.ResourceVersion)
                    .WithOne(p => p.TCharacterCasting)
                    .HasForeignKey<TCharacterCasting>(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_CharacterCasting_ResourceVersionID");

                entity.HasOne(d => d.VoiceResource)
                    .WithMany(p => p.TCharacterCasting)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.VoiceResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_CharacterCasting_CharacterResourceID");
            });

            modelBuilder.Entity<TCharacterCastingActor>(entity =>
            {
                entity.HasKey(e => e.CastingActorId)
                    .HasName("PK__t_Charac__EADD7409442B18F2");

                entity.ToTable("t_CharacterCasting_Actor", "vo");

                entity.Property(e => e.CastingActorId).HasColumnName("CastingActorID");

                entity.Property(e => e.ActorId).HasColumnName("ActorID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.TCharacterCastingActor)
                    .HasForeignKey(d => d.ActorId)
                    .HasConstraintName("FK_t_CharacterCasting_Actor_ActorID");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.TCharacterCastingActor)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_CharacterCasting_Actor_ResourceID");
            });

            modelBuilder.Entity<TCharacterDeltaHistory>(entity =>
            {
                entity.HasKey(e => e.CharacterDeltaHistoryId);

                entity.ToTable("t_CharacterDeltaHistory");

                entity.Property(e => e.CharacterDeltaHistoryId).HasColumnName("CharacterDeltaHistoryID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.DeltaGeneratedOnUtc)
                    .HasColumnName("DeltaGeneratedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCharacterGender>(entity =>
            {
                entity.HasKey(e => e.CharacterGenderId);

                entity.ToTable("t_CharacterGender");

                entity.Property(e => e.CharacterGenderId)
                    .HasColumnName("CharacterGenderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<TCharacterRace>(entity =>
            {
                entity.HasKey(e => e.CharacterRaceId);

                entity.ToTable("t_CharacterRace");

                entity.Property(e => e.CharacterRaceId).HasColumnName("CharacterRaceID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(48);
            });

            modelBuilder.Entity<TCharacterSubCharacter>(entity =>
            {
                entity.HasKey(e => new { e.ResourceVersionId, e.CharacterResourceId });

                entity.ToTable("t_CharacterSubCharacter");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.CharacterResourceId).HasColumnName("CharacterResourceID");

                entity.HasOne(d => d.CharacterResource)
                    .WithMany(p => p.TCharacterSubCharacter)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.CharacterResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_CharacterSubCharacter_CharacterResourceID");

                entity.HasOne(d => d.ResourceVersion)
                    .WithMany(p => p.TCharacterSubCharacter)
                    .HasForeignKey(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_CharacterSubCharacter_ResourceVersionID");
            });

            modelBuilder.Entity<TCharacterType>(entity =>
            {
                entity.HasKey(e => e.CharacterTypeId);

                entity.ToTable("t_CharacterType");

                entity.Property(e => e.CharacterTypeId)
                    .HasColumnName("CharacterTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(48);
            });

            modelBuilder.Entity<TCharacterVoice>(entity =>
            {
                entity.HasKey(e => new { e.ResourceVersionId, e.VoiceResourceId });

                entity.ToTable("t_CharacterVoice");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.VoiceResourceId).HasColumnName("VoiceResourceID");

                entity.HasOne(d => d.ResourceVersion)
                    .WithMany(p => p.TCharacterVoice)
                    .HasForeignKey(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_CharacterVoice_ResourceVersionID");

                entity.HasOne(d => d.VoiceResource)
                    .WithMany(p => p.TCharacterVoice)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.VoiceResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_CharacterVoice_VoiceResourceID");
            });

            modelBuilder.Entity<TCloneVoscriptGenerationSession>(entity =>
            {
                entity.HasKey(e => new { e.StringCloneEventId, e.LanguageId });

                entity.ToTable("t_CloneVOScriptGenerationSession", "vo");

                entity.Property(e => e.StringCloneEventId).HasColumnName("StringCloneEventID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.CloneStringWasVoeligible).HasColumnName("CloneStringWasVOEligible");

                entity.Property(e => e.VoscriptGenerationSessionId).HasColumnName("VOScriptGenerationSessionID");

                entity.HasOne(d => d.StringCloneEvent)
                    .WithMany(p => p.TCloneVoscriptGenerationSession)
                    .HasForeignKey(d => d.StringCloneEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_CloneVOScriptGenerationSession_StringCloneEventID");

                entity.HasOne(d => d.VoscriptGenerationSession)
                    .WithMany(p => p.TCloneVoscriptGenerationSession)
                    .HasForeignKey(d => d.VoscriptGenerationSessionId)
                    .HasConstraintName("FK_t_CloneVOSGS_VOSGSID");
            });

            modelBuilder.Entity<TConversation>(entity =>
            {
                entity.HasKey(e => e.ResourceVersionId);

                entity.ToTable("t_Conversation");

                entity.Property(e => e.ResourceVersionId)
                    .HasColumnName("ResourceVersionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CineDesignPointOfContactNameId).HasColumnName("CineDesignPointOfContactNameID");

                entity.Property(e => e.ComplexityNameId).HasColumnName("ComplexityNameID");

                entity.Property(e => e.ConversationTypeId).HasColumnName("ConversationTypeID");

                entity.Property(e => e.EditingPointOfContactNameId).HasColumnName("EditingPointOfContactNameID");

                entity.Property(e => e.Synopsis).IsRequired();

                entity.HasOne(d => d.CineDesignPointOfContactName)
                    .WithMany(p => p.TConversationCineDesignPointOfContactName)
                    .HasForeignKey(d => d.CineDesignPointOfContactNameId)
                    .HasConstraintName("FK_t_Conversation_CineDesignPointOfContactNameID");

                entity.HasOne(d => d.ComplexityName)
                    .WithMany(p => p.TConversationComplexityName)
                    .HasForeignKey(d => d.ComplexityNameId)
                    .HasConstraintName("FK_t_Conversation_ComplextyNameID");

                entity.HasOne(d => d.ConversationType)
                    .WithMany(p => p.TConversation)
                    .HasForeignKey(d => d.ConversationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Conversation_ConversationTypeID");

                entity.HasOne(d => d.EditingPointOfContactName)
                    .WithMany(p => p.TConversationEditingPointOfContactName)
                    .HasForeignKey(d => d.EditingPointOfContactNameId)
                    .HasConstraintName("FK_t_Conversation_EditingPointOfContactNameID");

                entity.HasOne(d => d.ResourceVersion)
                    .WithOne(p => p.TConversation)
                    .HasForeignKey<TConversation>(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Conversation_ResourceVersionID");
            });

            modelBuilder.Entity<TConversationExertionPalette>(entity =>
            {
                entity.HasKey(e => e.ResourceVersionId);

                entity.ToTable("t_ConversationExertionPalette");

                entity.Property(e => e.ResourceVersionId)
                    .HasColumnName("ResourceVersionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReferenceConversationResourceId).HasColumnName("ReferenceConversationResourceID");

                entity.HasOne(d => d.ReferenceConversationResource)
                    .WithMany(p => p.TConversationExertionPalette)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.ReferenceConversationResourceId)
                    .HasConstraintName("FK_t_ConversationEP_RefConvResID");

                entity.HasOne(d => d.ResourceVersion)
                    .WithOne(p => p.TConversationExertionPalette)
                    .HasForeignKey<TConversationExertionPalette>(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ConversationEP_ResourceVersionID");
            });

            modelBuilder.Entity<TConversationLine>(entity =>
            {
                entity.HasKey(e => new { e.ResourceVersionId, e.LineId });

                entity.ToTable("t_ConversationLine");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.CinematicsComment).IsRequired();

                entity.Property(e => e.DesignComment).IsRequired();

                entity.Property(e => e.HoverTextStringId).HasColumnName("HoverTextStringID");

                entity.Property(e => e.ParaphraseCategoryResourceId).HasColumnName("ParaphraseCategoryResourceID");

                entity.Property(e => e.ParaphraseStringId).HasColumnName("ParaphraseStringID");

                entity.Property(e => e.TextStringId).HasColumnName("TextStringID");

                entity.HasOne(d => d.ParaphraseCategoryResource)
                    .WithMany(p => p.TConversationLine)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.ParaphraseCategoryResourceId)
                    .HasConstraintName("FK_t_ConversationLine_ParaphraseCategoryResourceID");

                entity.HasOne(d => d.ResourceVersion)
                    .WithMany(p => p.TConversationLine)
                    .HasForeignKey(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ConversationLine_ResourceVersionID");
            });

            modelBuilder.Entity<TConversationLineTransition>(entity =>
            {
                entity.HasKey(e => e.ConversationLineTransitionId);

                entity.ToTable("t_ConversationLineTransition");

                entity.Property(e => e.ConversationLineTransitionId).HasColumnName("ConversationLineTransitionID");

                entity.Property(e => e.ChildLineId).HasColumnName("ChildLineID");

                entity.Property(e => e.HoverTextStringId).HasColumnName("HoverTextStringID");

                entity.Property(e => e.ParaphraseCategoryResourceId).HasColumnName("ParaphraseCategoryResourceID");

                entity.Property(e => e.ParaphraseStringId).HasColumnName("ParaphraseStringID");

                entity.Property(e => e.ParentLineId).HasColumnName("ParentLineID");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.HasOne(d => d.ParaphraseCategoryResource)
                    .WithMany(p => p.TConversationLineTransition)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.ParaphraseCategoryResourceId)
                    .HasConstraintName("FK_t_ConversationLineTransition_ParaphraseCategoryResourceID");

                entity.HasOne(d => d.TConversationLine)
                    .WithMany(p => p.TConversationLineTransitionTConversationLine)
                    .HasForeignKey(d => new { d.ResourceVersionId, d.ChildLineId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ConversationLineTransition_ResourceVersionIDChildLineID");

                entity.HasOne(d => d.TConversationLineNavigation)
                    .WithMany(p => p.TConversationLineTransitionTConversationLineNavigation)
                    .HasForeignKey(d => new { d.ResourceVersionId, d.ParentLineId })
                    .HasConstraintName("FK_t_ConversationLineTransition_ResourceVersionIDParentLineID");
            });

            modelBuilder.Entity<TConversationType>(entity =>
            {
                entity.HasKey(e => e.ConversationTypeId);

                entity.ToTable("t_ConversationType");

                entity.Property(e => e.ConversationTypeId)
                    .HasColumnName("ConversationTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(48)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCurrentEnglishStringCache>(entity =>
            {
                entity.HasKey(e => new { e.StringId, e.BranchId })
                    .HasName("PK__t_Curren__58FFB81340385C42");

                entity.ToTable("t_CurrentEnglishStringCache", "vope");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.FriendlyStringId).HasColumnName("FriendlyStringID");

                entity.Property(e => e.LocalizedVersionId).HasColumnName("LocalizedVersionID");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.Vocomment)
                    .IsRequired()
                    .HasColumnName("VOComment");
            });

            modelBuilder.Entity<TCurrentNonVoenglishStringCache>(entity =>
            {
                entity.HasKey(e => new { e.StringId, e.BranchId })
                    .HasName("PK__t_Curren__58FFB813571BC19A");

                entity.ToTable("t_CurrentNonVOEnglishStringCache", "vope");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.FriendlyStringId).HasColumnName("FriendlyStringID");

                entity.Property(e => e.LocalizedVersionId).HasColumnName("LocalizedVersionID");

                entity.Property(e => e.MaxLvid).HasColumnName("MaxLVID");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.Vocomment)
                    .IsRequired()
                    .HasColumnName("VOComment");
            });

            modelBuilder.Entity<TData>(entity =>
            {
                entity.HasKey(e => e.DataId);

                entity.ToTable("t_Data", "trend");

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<TDataImportSession>(entity =>
            {
                entity.HasKey(e => e.DataImportSessionId);

                entity.ToTable("t_DataImportSession");

                entity.Property(e => e.DataImportSessionId).HasColumnName("DataImportSessionID");

                entity.Property(e => e.AppVersion)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TDataTag>(entity =>
            {
                entity.HasKey(e => e.DataTagId);

                entity.ToTable("t_DataTag", "trend");

                entity.Property(e => e.DataTagId)
                    .HasColumnName("DataTagID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TExportIntentLog>(entity =>
            {
                entity.HasKey(e => e.ExportIntentLogId);

                entity.ToTable("t_ExportIntentLog", "loc");

                entity.Property(e => e.ExportIntentLogId).HasColumnName("ExportIntentLogID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.StringId).HasColumnName("StringID");
            });

            modelBuilder.Entity<TExportSession>(entity =>
            {
                entity.HasKey(e => e.ExportSessionId);

                entity.ToTable("t_ExportSession", "loc");

                entity.Property(e => e.ExportSessionId).HasColumnName("ExportSessionID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExportSessionTypeId).HasColumnName("ExportSessionTypeID");

                entity.Property(e => e.RecalledBy)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RecalledOnUtc)
                    .HasColumnName("RecalledOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.UniqueSessionId)
                    .IsRequired()
                    .HasColumnName("UniqueSessionID")
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(CONVERT([varchar](48),newid(),0))");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TExportSession)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ExportSession_BranchID");

                entity.HasOne(d => d.ExportSessionType)
                    .WithMany(p => p.TExportSession)
                    .HasForeignKey(d => d.ExportSessionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ExportSession_ExportSessionTypeID");

                entity.HasOne(d => d.TranslationPartner)
                    .WithMany(p => p.TExportSession)
                    .HasForeignKey(d => d.TranslationPartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ExportSession_TranslationPartnerID");
            });

            modelBuilder.Entity<TExportSessionInfo>(entity =>
            {
                entity.HasKey(e => e.ExportSessionId);

                entity.ToTable("t_ExportSessionInfo", "loc");

                entity.Property(e => e.ExportSessionId)
                    .HasColumnName("ExportSessionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.ExportSession)
                    .WithOne(p => p.TExportSessionInfo)
                    .HasForeignKey<TExportSessionInfo>(d => d.ExportSessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ExportSessionInfo_ExportSessionID");
            });

            modelBuilder.Entity<TExportSessionString>(entity =>
            {
                entity.HasKey(e => e.ExportSessionStringId);

                entity.ToTable("t_ExportSessionString", "loc");

                entity.HasIndex(e => new { e.Status, e.ExportSessionId, e.StringId })
                    .HasName("IX_t_ExportSessionString_ExportSessionIDStringID")
                    .IsUnique();

                entity.Property(e => e.ExportSessionStringId).HasColumnName("ExportSessionStringID");

                entity.Property(e => e.CompareDate).HasColumnType("datetime");

                entity.Property(e => e.ExportSessionId).HasColumnName("ExportSessionID");

                entity.Property(e => e.LastExportSessionStringOperationId).HasColumnName("LastExportSessionStringOperationID");

                entity.Property(e => e.PreviousExportSessionStringId).HasColumnName("PreviousExportSessionStringID");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.HasOne(d => d.ExportSession)
                    .WithMany(p => p.TExportSessionString)
                    .HasForeignKey(d => d.ExportSessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ExportSessionString_ExportSessionID");

                entity.HasOne(d => d.LastExportSessionStringOperation)
                    .WithMany(p => p.TExportSessionString)
                    .HasForeignKey(d => d.LastExportSessionStringOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ExportSessionString_LastExportSessionStringOperationID");

                entity.HasOne(d => d.TResourceVersionString)
                    .WithMany(p => p.TExportSessionString)
                    .HasForeignKey(d => new { d.ResourceVersionId, d.StringId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ExportSessionString_ResourceVersionIDStringID");
            });

            modelBuilder.Entity<TExportSessionStringHistory>(entity =>
            {
                entity.HasKey(e => e.ExportSessionStringHistoryId);

                entity.ToTable("t_ExportSessionStringHistory", "loc");

                entity.Property(e => e.ExportSessionStringHistoryId).HasColumnName("ExportSessionStringHistoryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ExportSessionStringId).HasColumnName("ExportSessionStringID");

                entity.Property(e => e.ExportSessionStringOperationId).HasColumnName("ExportSessionStringOperationID");

                entity.Property(e => e.NewCompareDate).HasColumnType("datetime");

                entity.Property(e => e.OldCompareDate).HasColumnType("datetime");

                entity.HasOne(d => d.ExportSessionString)
                    .WithMany(p => p.TExportSessionStringHistory)
                    .HasForeignKey(d => d.ExportSessionStringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ExportSessionStringHistory_ExportSessionStringID");

                entity.HasOne(d => d.ExportSessionStringOperation)
                    .WithMany(p => p.TExportSessionStringHistory)
                    .HasForeignKey(d => d.ExportSessionStringOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ExportSessionStringHistory_ExportSessionStringOperationID");
            });

            modelBuilder.Entity<TExportSessionStringOperation>(entity =>
            {
                entity.HasKey(e => e.ExportSessionStringOperationId);

                entity.ToTable("t_ExportSessionStringOperation", "loc");

                entity.Property(e => e.ExportSessionStringOperationId)
                    .HasColumnName("ExportSessionStringOperationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TExportSessionType>(entity =>
            {
                entity.HasKey(e => e.ExportSessionTypeId);

                entity.ToTable("t_ExportSessionType", "loc");

                entity.Property(e => e.ExportSessionTypeId)
                    .HasColumnName("ExportSessionTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TForeignVoforecastData>(entity =>
            {
                entity.HasKey(e => e.ForeignVoforecastDataId);

                entity.ToTable("t_ForeignVOForecastData");

                entity.Property(e => e.ForeignVoforecastDataId).HasColumnName("ForeignVOForecastDataID");

                entity.Property(e => e.EnglishText).IsRequired();

                entity.Property(e => e.FriendlyStringId).HasColumnName("FriendlyStringID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LastEnglishPrintedOnUtc)
                    .HasColumnName("LastEnglishPrintedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEnglishReceivedOn).HasColumnType("datetime");

                entity.Property(e => e.LastForeignPrintedOnUtc)
                    .HasColumnName("LastForeignPrintedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastImportedOnUtc)
                    .HasColumnName("LastImportedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastSentForTranslationOnUtc)
                    .HasColumnName("LastSentForTranslationOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductionState)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ScopeSubTag).IsUnicode(false);

                entity.Property(e => e.ScopeTag).IsUnicode(false);

                entity.Property(e => e.ScriptResource)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.Vocomment)
                    .IsRequired()
                    .HasColumnName("VOComment");

                entity.Property(e => e.Voeligible).HasColumnName("VOEligible");

                entity.Property(e => e.Voice)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Voready).HasColumnName("VOReady");

                entity.Property(e => e.VoscriptId).HasColumnName("VOScriptID");

                entity.Property(e => e.WritingWorkflowState)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TGenericEnumeration>(entity =>
            {
                entity.HasKey(e => new { e.ResourceVersionId, e.EnumerationId });

                entity.ToTable("t_GenericEnumeration");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.EnumerationId).HasColumnName("EnumerationID");

                entity.Property(e => e.EnumerationName).IsRequired();

                entity.HasOne(d => d.ResourceVersion)
                    .WithMany(p => p.TGenericEnumeration)
                    .HasForeignKey(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_GenericEnumeration_ResourceVersionID");
            });

            modelBuilder.Entity<TGlobalParameter>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("t_GlobalParameter");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TGrammarEnumeration>(entity =>
            {
                entity.HasKey(e => e.GrammarEnumerationId);

                entity.ToTable("t_GrammarEnumeration");

                entity.Property(e => e.GrammarEnumerationId).HasColumnName("GrammarEnumerationID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ChangelistId).HasColumnName("ChangelistID");

                entity.Property(e => e.DataImportSessionId).HasColumnName("DataImportSessionID");

                entity.Property(e => e.NounGenderResourceId).HasColumnName("NounGenderResourceID");

                entity.Property(e => e.NounNumberResourceId).HasColumnName("NounNumberResourceID");

                entity.Property(e => e.PhraseElementResourceId).HasColumnName("PhraseElementResourceID");

                entity.Property(e => e.PhraseTemplateResourceId).HasColumnName("PhraseTemplateResourceID");

                entity.Property(e => e.WordClassResourceId).HasColumnName("WordClassResourceID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TGrammarEnumeration)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_GrammarEnumeration_BranchID");

                entity.HasOne(d => d.Changelist)
                    .WithMany(p => p.TGrammarEnumeration)
                    .HasForeignKey(d => d.ChangelistId)
                    .HasConstraintName("FK_t_GrammarEnumeration_ChangelistID");

                entity.HasOne(d => d.DataImportSession)
                    .WithMany(p => p.TGrammarEnumeration)
                    .HasForeignKey(d => d.DataImportSessionId)
                    .HasConstraintName("FK_t_GrammarEnumeration_DataImportSessionID");

                entity.HasOne(d => d.NounGenderResource)
                    .WithMany(p => p.TGrammarEnumerationNounGenderResource)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.NounGenderResourceId)
                    .HasConstraintName("FK_t_GrammarEnumeration_NounGenderResourceID");

                entity.HasOne(d => d.NounNumberResource)
                    .WithMany(p => p.TGrammarEnumerationNounNumberResource)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.NounNumberResourceId)
                    .HasConstraintName("FK_t_GrammarEnumeration_NounNumberResourceID");

                entity.HasOne(d => d.PhraseElementResource)
                    .WithMany(p => p.TGrammarEnumerationPhraseElementResource)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.PhraseElementResourceId)
                    .HasConstraintName("FK_t_GrammarEnumeration_PhraseElementResourceID");

                entity.HasOne(d => d.PhraseTemplateResource)
                    .WithMany(p => p.TGrammarEnumerationPhraseTemplateResource)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.PhraseTemplateResourceId)
                    .HasConstraintName("FK_t_GrammarEnumeration_PhraseTemplateResourceID");

                entity.HasOne(d => d.WordClassResource)
                    .WithMany(p => p.TGrammarEnumerationWordClassResource)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.WordClassResourceId)
                    .HasConstraintName("FK_t_GrammarEnumeration_WordClassResourceID");
            });

            modelBuilder.Entity<TGrammarModifierPosition>(entity =>
            {
                entity.HasKey(e => e.ModifierPositionId);

                entity.ToTable("t_GrammarModifierPosition");

                entity.Property(e => e.ModifierPositionId)
                    .HasColumnName("ModifierPositionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(48)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TImportRecallHistory>(entity =>
            {
                entity.HasKey(e => e.ImportRecallHistoryId);

                entity.ToTable("t_ImportRecallHistory", "loc");

                entity.Property(e => e.ImportRecallHistoryId).HasColumnName("ImportRecallHistoryID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<TImportSession>(entity =>
            {
                entity.HasKey(e => e.ImportSessionId);

                entity.ToTable("t_ImportSession", "loc");

                entity.Property(e => e.ImportSessionId).HasColumnName("ImportSessionID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.GameChangelistId)
                    .HasColumnName("GameChangelistID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ImportedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ImportedIntoGameOnUtc)
                    .HasColumnName("ImportedIntoGameOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImportedOnUtc)
                    .HasColumnName("ImportedOnUTC")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TImportSessionStage>(entity =>
            {
                entity.HasKey(e => e.ImportSessionStageId);

                entity.ToTable("t_ImportSessionStage", "loc");

                entity.Property(e => e.ImportSessionStageId).HasColumnName("ImportSessionStageID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<TImportSessionStageString>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.LanguageId, e.VariantId, e.StringId });

                entity.ToTable("t_ImportSessionStageString", "loc");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.ImportSessionStageId).HasColumnName("ImportSessionStageID");

                entity.Property(e => e.LocalizedVersionId).HasColumnName("LocalizedVersionID");

                entity.Property(e => e.PreviousImportSessionStringId).HasColumnName("PreviousImportSessionStringID");

                entity.Property(e => e.SourceResourceVersionId).HasColumnName("SourceResourceVersionID");

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerTrackingId).HasColumnName("TranslationPartnerTrackingID");

                entity.Property(e => e.VorequestOnUtc)
                    .HasColumnName("VORequestOnUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TImportSessionStageString)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionStageString_BranchID");

                entity.HasOne(d => d.ImportSessionStage)
                    .WithMany(p => p.TImportSessionStageString)
                    .HasForeignKey(d => d.ImportSessionStageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionStageString_ImportSessionStageID");

                entity.HasOne(d => d.PreviousImportSessionString)
                    .WithMany(p => p.TImportSessionStageString)
                    .HasForeignKey(d => d.PreviousImportSessionStringId)
                    .HasConstraintName("FK_t_ImportSessionStageString_PreviousImportSessionStringID");

                entity.HasOne(d => d.TranslationPartner)
                    .WithMany(p => p.TImportSessionStageString)
                    .HasForeignKey(d => d.TranslationPartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionStageString_TranslationPartnerID");

                entity.HasOne(d => d.TLanguageVariant)
                    .WithMany(p => p.TImportSessionStageString)
                    .HasForeignKey(d => new { d.LanguageId, d.VariantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionStageString_LanguageIDVariantID");
            });

            modelBuilder.Entity<TImportSessionStageStringGrammarText>(entity =>
            {
                entity.HasKey(e => new { e.ImportSessionStageId, e.BranchId, e.LanguageId, e.VariantId, e.StringId, e.GrammarNounGenderId, e.GrammarNounNumberId, e.BeginsWithVowelSound });

                entity.ToTable("t_ImportSessionStageStringGrammarText", "loc");

                entity.Property(e => e.ImportSessionStageId).HasColumnName("ImportSessionStageID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.GrammarNounGenderId).HasColumnName("GrammarNounGenderID");

                entity.Property(e => e.GrammarNounNumberId).HasColumnName("GrammarNounNumberID");

                entity.Property(e => e.LocalizedVersionId).HasColumnName("LocalizedVersionID");

                entity.Property(e => e.ModifierPositionId).HasColumnName("ModifierPositionID");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.ImportSessionStage)
                    .WithMany(p => p.TImportSessionStageStringGrammarText)
                    .HasForeignKey(d => d.ImportSessionStageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionStageStringGrammarText_ImportSessionStageID");

                entity.HasOne(d => d.TImportSessionStageString)
                    .WithMany(p => p.TImportSessionStageStringGrammarText)
                    .HasForeignKey(d => new { d.BranchId, d.LanguageId, d.VariantId, d.StringId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionStageStringGrammarText_ImportSessionStageString");
            });

            modelBuilder.Entity<TImportSessionString>(entity =>
            {
                entity.HasKey(e => e.ImportSessionStringId);

                entity.ToTable("t_ImportSessionString", "loc");

                entity.HasIndex(e => e.Status);

                entity.HasIndex(e => new { e.ImportSessionId, e.PreviousImportSessionStringId })
                    .HasName("IX_t_ImportSessionString_ImportSessionID");

                entity.HasIndex(e => new { e.LanguageId, e.VariantId, e.StringId, e.ImportSessionStringId })
                    .HasName("IX_t_ImportSessionString_StringTuplet");

                entity.HasIndex(e => new { e.Status, e.LanguageId, e.StringId, e.BranchId, e.VariantId, e.ImportSessionStringId })
                    .HasName("IX_t_ImportSessionString_StringTupletWithStatus");

                entity.Property(e => e.ImportSessionStringId).HasColumnName("ImportSessionStringID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ImportSessionId).HasColumnName("ImportSessionID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LocalizedVersionId).HasColumnName("LocalizedVersionID");

                entity.Property(e => e.PreviousImportSessionStringId).HasColumnName("PreviousImportSessionStringID");

                entity.Property(e => e.SourceResourceVersionId).HasColumnName("SourceResourceVersionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerTrackingId).HasColumnName("TranslationPartnerTrackingID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.VorequestOnUtc)
                    .HasColumnName("VORequestOnUTC")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TImportSessionString)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionString_BranchID");

                entity.HasOne(d => d.ImportSession)
                    .WithMany(p => p.TImportSessionString)
                    .HasForeignKey(d => d.ImportSessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionString_ImportSessionID");

                entity.HasOne(d => d.PreviousImportSessionString)
                    .WithMany(p => p.InversePreviousImportSessionString)
                    .HasForeignKey(d => d.PreviousImportSessionStringId)
                    .HasConstraintName("FK_t_ImportSessionString_PreviousImportSessionStringID");

                entity.HasOne(d => d.TranslationPartner)
                    .WithMany(p => p.TImportSessionString)
                    .HasForeignKey(d => d.TranslationPartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionString_TranslationPartnerID");

                entity.HasOne(d => d.TLanguageVariant)
                    .WithMany(p => p.TImportSessionString)
                    .HasForeignKey(d => new { d.LanguageId, d.VariantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionString_LanguageIDVariantID");
            });

            modelBuilder.Entity<TImportSessionStringGrammarText>(entity =>
            {
                entity.HasKey(e => new { e.ImportSessionStringId, e.GrammarNounGenderId, e.GrammarNounNumberId, e.BeginsWithVowelSound });

                entity.ToTable("t_ImportSessionStringGrammarText", "loc");

                entity.Property(e => e.ImportSessionStringId).HasColumnName("ImportSessionStringID");

                entity.Property(e => e.GrammarNounGenderId).HasColumnName("GrammarNounGenderID");

                entity.Property(e => e.GrammarNounNumberId).HasColumnName("GrammarNounNumberID");

                entity.Property(e => e.LocalizedVersionId).HasColumnName("LocalizedVersionID");

                entity.Property(e => e.ModifierPositionId).HasColumnName("ModifierPositionID");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.ImportSessionString)
                    .WithMany(p => p.TImportSessionStringGrammarText)
                    .HasForeignKey(d => d.ImportSessionStringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionStringGrammarText_ImportSessionStringID");
            });

            modelBuilder.Entity<TImportSessionStringPhoneticText>(entity =>
            {
                entity.HasKey(e => e.ImportSessionStringId);

                entity.ToTable("t_ImportSessionStringPhoneticText", "loc");

                entity.Property(e => e.ImportSessionStringId)
                    .HasColumnName("ImportSessionStringID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<TImportSessionStringRecallHistory>(entity =>
            {
                entity.HasKey(e => e.ImportSessionStringRecallHistoryId);

                entity.ToTable("t_ImportSessionStringRecallHistory", "loc");

                entity.Property(e => e.ImportSessionStringRecallHistoryId).HasColumnName("ImportSessionStringRecallHistoryID");

                entity.Property(e => e.ImportRecallHistoryId).HasColumnName("ImportRecallHistoryID");

                entity.Property(e => e.ImportSessionStringId).HasColumnName("ImportSessionStringID");

                entity.Property(e => e.NextImportSessionStringId).HasColumnName("NextImportSessionStringID");

                entity.HasOne(d => d.ImportRecallHistory)
                    .WithMany(p => p.TImportSessionStringRecallHistory)
                    .HasForeignKey(d => d.ImportRecallHistoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionStringRecallHistory_ImportRecallHistoryID");

                entity.HasOne(d => d.ImportSessionString)
                    .WithMany(p => p.TImportSessionStringRecallHistoryImportSessionString)
                    .HasForeignKey(d => d.ImportSessionStringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ImportSessionStringRecallHistory_ImportSessionStringID");

                entity.HasOne(d => d.NextImportSessionString)
                    .WithMany(p => p.TImportSessionStringRecallHistoryNextImportSessionString)
                    .HasForeignKey(d => d.NextImportSessionStringId)
                    .HasConstraintName("FK_t_ImportSessionStringRecallHistory_NextImportSessionStringID");
            });

            modelBuilder.Entity<TImportSessionStringText>(entity =>
            {
                entity.HasKey(e => e.ImportSessionStringId);

                entity.ToTable("t_ImportSessionStringText", "loc");

                entity.Property(e => e.ImportSessionStringId)
                    .HasColumnName("ImportSessionStringID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<TJournalNode>(entity =>
            {
                entity.HasKey(e => new { e.ResourceVersionId, e.NodeId });

                entity.ToTable("t_JournalNode");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.Property(e => e.TextStringId).HasColumnName("TextStringID");

                entity.Property(e => e.WritingComment).IsRequired();

                entity.HasOne(d => d.ResourceVersion)
                    .WithMany(p => p.TJournalNode)
                    .HasForeignKey(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_JournalNode_ResourceVersionID");

                entity.HasOne(d => d.TextString)
                    .WithMany(p => p.TJournalNode)
                    .HasForeignKey(d => d.TextStringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_JournalNode_TextStringID");
            });

            modelBuilder.Entity<TJournalNodeTransition>(entity =>
            {
                entity.HasKey(e => e.JournalNodeTransitionId);

                entity.ToTable("t_JournalNodeTransition");

                entity.Property(e => e.JournalNodeTransitionId).HasColumnName("JournalNodeTransitionID");

                entity.Property(e => e.ChildNodeId).HasColumnName("ChildNodeID");

                entity.Property(e => e.ParentNodeId).HasColumnName("ParentNodeID");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.HasOne(d => d.TJournalNode)
                    .WithMany(p => p.TJournalNodeTransitionTJournalNode)
                    .HasForeignKey(d => new { d.ResourceVersionId, d.ChildNodeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JournalNodeTransition_ResourceVersionIDChildNodeID");

                entity.HasOne(d => d.TJournalNodeNavigation)
                    .WithMany(p => p.TJournalNodeTransitionTJournalNodeNavigation)
                    .HasForeignKey(d => new { d.ResourceVersionId, d.ParentNodeId })
                    .HasConstraintName("FK_JournalNodeTransition_ResourceVersionIDParentNodeID");
            });

            modelBuilder.Entity<TLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("t_Language", "loc");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectMetadata)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TLanguageGrammar>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("t_LanguageGrammar", "loc");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CapitalizationStyleId).HasColumnName("CapitalizationStyleID");

                entity.HasOne(d => d.Language)
                    .WithOne(p => p.TLanguageGrammar)
                    .HasForeignKey<TLanguageGrammar>(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_LanguageGrammar_LanguageID");
            });

            modelBuilder.Entity<TLanguageGrammarNounGender>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.GrammarNounGenderId });

                entity.ToTable("t_LanguageGrammarNounGender", "loc");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.GrammarNounGenderId).HasColumnName("GrammarNounGenderID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.TLanguageGrammarNounGender)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_LanguageGrammarNounGender_LanguageID");
            });

            modelBuilder.Entity<TLanguageGrammarNounNumber>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.GrammarNounNumberId });

                entity.ToTable("t_LanguageGrammarNounNumber", "loc");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.GrammarNounNumberId).HasColumnName("GrammarNounNumberID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.TLanguageGrammarNounNumber)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_LanguageGrammarNounNumber_LanguageID");
            });

            modelBuilder.Entity<TLanguageTag>(entity =>
            {
                entity.HasKey(e => e.Tag);

                entity.ToTable("t_LanguageTag", "loc");

                entity.Property(e => e.Tag)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.TLanguageTag)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_LanguageTag_LanguageID");
            });

            modelBuilder.Entity<TLanguageVariant>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.VariantId });

                entity.ToTable("t_LanguageVariant", "loc");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.TLanguageVariant)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_LanguageVariant_LanguageID");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.TLanguageVariant)
                    .HasForeignKey(d => d.VariantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_LanguageVariant_VariantID");
            });

            modelBuilder.Entity<TModelType>(entity =>
            {
                entity.HasKey(e => e.ModelTypeId);

                entity.ToTable("t_ModelType");

                entity.Property(e => e.ModelTypeId).HasColumnName("ModelTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("t_Module");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TParaphraseCategory>(entity =>
            {
                entity.HasKey(e => e.ResourceVersionId);

                entity.ToTable("t_ParaphraseCategory");

                entity.Property(e => e.ResourceVersionId)
                    .HasColumnName("ResourceVersionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ParaphraseCategoryTypeId).HasColumnName("ParaphraseCategoryTypeID");

                entity.HasOne(d => d.ParaphraseCategoryType)
                    .WithMany(p => p.TParaphraseCategory)
                    .HasForeignKey(d => d.ParaphraseCategoryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ParaphraseCategory_ParaphraseCategoryTypeID");

                entity.HasOne(d => d.ResourceVersion)
                    .WithOne(p => p.TParaphraseCategory)
                    .HasForeignKey<TParaphraseCategory>(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ParaphraseCategory_ResourceVersionID");
            });

            modelBuilder.Entity<TParaphraseCategoryType>(entity =>
            {
                entity.HasKey(e => e.ParaphraseCategoryTypeId);

                entity.ToTable("t_ParaphraseCategoryType");

                entity.Property(e => e.ParaphraseCategoryTypeId)
                    .HasColumnName("ParaphraseCategoryTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TProductionState>(entity =>
            {
                entity.HasKey(e => e.ProductionStateId);

                entity.ToTable("t_ProductionState");

                entity.Property(e => e.ProductionStateId)
                    .HasColumnName("ProductionStateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(48)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TRecordingStatus>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_t_Name");

                entity.ToTable("t_RecordingStatus", "vo");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.RecordingStatusId).HasColumnName("RecordingStatusID");
            });

            modelBuilder.Entity<TRecordingType>(entity =>
            {
                entity.HasKey(e => e.RecordingTypeId);

                entity.ToTable("t_RecordingType");

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.RecordingTypeId).HasColumnName("RecordingTypeID");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TReducedScriptsCache>(entity =>
            {
                entity.HasKey(e => new { e.ParentResourceGuid, e.VoiceResourceGuid, e.VoscriptId })
                    .HasName("PK__t_Reduce__F2377D5410543EF6");

                entity.ToTable("t_ReducedScriptsCache", "vope");

                entity.Property(e => e.ParentResourceGuid)
                    .HasColumnName("ParentResourceGUID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceResourceGuid)
                    .HasColumnName("VoiceResourceGUID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.VoscriptId).HasColumnName("VOScriptID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.HasAprintedVersion).HasColumnName("HasAPrintedVersion");

                entity.Property(e => e.ParentResourceName)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceResourceName)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TRepositoryPath>(entity =>
            {
                entity.HasKey(e => e.RepositoryPathId);

                entity.ToTable("t_RepositoryPath");

                entity.Property(e => e.RepositoryPathId).HasColumnName("RepositoryPathID");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TResource>(entity =>
            {
                entity.HasKey(e => new { e.ResourceUniqueId, e.BranchId });

                entity.ToTable("t_Resource");

                entity.HasIndex(e => e.BranchId);

                entity.HasIndex(e => e.ResourceId)
                    .IsUnique();

                entity.Property(e => e.ResourceUniqueId)
                    .HasColumnName("ResourceUniqueID")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("ResourceID")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TResource)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Resource_BranchID");
            });

            modelBuilder.Entity<TResourceHistory>(entity =>
            {
                entity.HasKey(e => e.ResourceHistoryId);

                entity.ToTable("t_ResourceHistory");

                entity.Property(e => e.ResourceHistoryId).HasColumnName("ResourceHistoryID");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ResourceUniqueId)
                    .IsRequired()
                    .HasColumnName("ResourceUniqueID")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.TResourceHistory)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceHistory_ResourceID");
            });

            modelBuilder.Entity<TResourceName>(entity =>
            {
                entity.HasKey(e => e.ResourceNameId);

                entity.ToTable("t_ResourceName");

                entity.Property(e => e.ResourceNameId).HasColumnName("ResourceNameID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TResourceType>(entity =>
            {
                entity.HasKey(e => e.ResourceTypeId);

                entity.ToTable("t_ResourceType");

                entity.Property(e => e.ResourceTypeId).HasColumnName("ResourceTypeID");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TResourceVersion>(entity =>
            {
                entity.HasKey(e => e.ResourceVersionId);

                entity.ToTable("t_ResourceVersion");

                entity.HasIndex(e => new { e.ResourceVersionId, e.BranchId, e.ResourceId, e.Status })
                    .HasName("IX_t_ResourceVersion");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ChangelistId).HasColumnName("ChangelistID");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.DataImportSessionId).HasColumnName("DataImportSessionID");

                entity.Property(e => e.FolderResourceNameId).HasColumnName("FolderResourceNameID");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ModelTypeId).HasColumnName("ModelTypeID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.NameResourceNameId).HasColumnName("NameResourceNameID");

                entity.Property(e => e.PreviousResourceVersionId).HasColumnName("PreviousResourceVersionID");

                entity.Property(e => e.ProductionStateId).HasColumnName("ProductionStateID");

                entity.Property(e => e.RepositoryPathId).HasColumnName("RepositoryPathID");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ResourceTypeId).HasColumnName("ResourceTypeID");

                entity.Property(e => e.ScopeSubTagCaseInsensitiveNameId).HasColumnName("ScopeSubTagCaseInsensitiveNameID");

                entity.Property(e => e.ScopeTagCaseInsensitiveNameId).HasColumnName("ScopeTagCaseInsensitiveNameID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeTagCaseInsensitiveNameId).HasColumnName("TypeTagCaseInsensitiveNameID");

                entity.Property(e => e.WritingPointOfContactNameId).HasColumnName("WritingPointOfContactNameID");

                entity.Property(e => e.WritingWorkflowStateId).HasColumnName("WritingWorkflowStateID");

                entity.HasOne(d => d.Changelist)
                    .WithMany(p => p.TResourceVersion)
                    .HasForeignKey(d => d.ChangelistId)
                    .HasConstraintName("FK_t_ResourceVersion_ChangelistID");

                entity.HasOne(d => d.DataImportSession)
                    .WithMany(p => p.TResourceVersion)
                    .HasForeignKey(d => d.DataImportSessionId)
                    .HasConstraintName("FK_t_ResourceVersion_DataImportSessionID");

                entity.HasOne(d => d.FolderResourceName)
                    .WithMany(p => p.TResourceVersionFolderResourceName)
                    .HasForeignKey(d => d.FolderResourceNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersion_FolderResourceNameID");

                entity.HasOne(d => d.ModelType)
                    .WithMany(p => p.TResourceVersion)
                    .HasForeignKey(d => d.ModelTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersion_ModelTypeID");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.TResourceVersion)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersion_ModuleID");

                entity.HasOne(d => d.NameResourceName)
                    .WithMany(p => p.TResourceVersionNameResourceName)
                    .HasForeignKey(d => d.NameResourceNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersion_NameResourceNameID");

                entity.HasOne(d => d.PreviousResourceVersion)
                    .WithMany(p => p.InversePreviousResourceVersion)
                    .HasForeignKey(d => d.PreviousResourceVersionId)
                    .HasConstraintName("FK_t_ResourceVersion_PreviousResourceVersionID");

                entity.HasOne(d => d.ProductionState)
                    .WithMany(p => p.TResourceVersion)
                    .HasForeignKey(d => d.ProductionStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersion_ProductionStateID");

                entity.HasOne(d => d.RepositoryPath)
                    .WithMany(p => p.TResourceVersion)
                    .HasForeignKey(d => d.RepositoryPathId)
                    .HasConstraintName("FK_t_ResourceVersion_RepositoryPathID");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.TResourceVersion)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersion_ResourceID");

                entity.HasOne(d => d.ResourceType)
                    .WithMany(p => p.TResourceVersion)
                    .HasForeignKey(d => d.ResourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersion_ResourceTypeID");

                entity.HasOne(d => d.ScopeSubTagCaseInsensitiveName)
                    .WithMany(p => p.TResourceVersionScopeSubTagCaseInsensitiveName)
                    .HasForeignKey(d => d.ScopeSubTagCaseInsensitiveNameId)
                    .HasConstraintName("FK_t_ResourceVersion_ScopeSubTagCaseInsensitiveNameID");

                entity.HasOne(d => d.ScopeTagCaseInsensitiveName)
                    .WithMany(p => p.TResourceVersionScopeTagCaseInsensitiveName)
                    .HasForeignKey(d => d.ScopeTagCaseInsensitiveNameId)
                    .HasConstraintName("FK_t_ResourceVersion_ScopeTagCaseInsensitiveNameID");

                entity.HasOne(d => d.TypeTagCaseInsensitiveName)
                    .WithMany(p => p.TResourceVersionTypeTagCaseInsensitiveName)
                    .HasForeignKey(d => d.TypeTagCaseInsensitiveNameId)
                    .HasConstraintName("FK_t_ResourceVersion_TypeTagCaseInsensitiveNameID");

                entity.HasOne(d => d.WritingPointOfContactName)
                    .WithMany(p => p.TResourceVersionWritingPointOfContactName)
                    .HasForeignKey(d => d.WritingPointOfContactNameId)
                    .HasConstraintName("FK_t_ResourceVersion_WritingPointOfContactNameID");

                entity.HasOne(d => d.WritingWorkflowState)
                    .WithMany(p => p.TResourceVersion)
                    .HasForeignKey(d => d.WritingWorkflowStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersion_WritingWorkflowStateID");
            });

            modelBuilder.Entity<TResourceVersionString>(entity =>
            {
                entity.HasKey(e => new { e.ResourceVersionId, e.StringId });

                entity.ToTable("t_ResourceVersionString");

                entity.HasIndex(e => new { e.IsLocalizationReady, e.WordCount, e.StringTypeId, e.ResourceVersionId, e.StringId })
                    .HasName("IX_t_ResourceVersionString_EligibleExportData")
                    .HasFilter("([IsTranslationEligible]=(1))");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.ActorIntensityStringVoenumId).HasColumnName("ActorIntensityStringVOEnumID");

                entity.Property(e => e.ActorVolumeStringVoenumId).HasColumnName("ActorVolumeStringVOEnumID");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsVoeligible).HasColumnName("IsVOEligible");

                entity.Property(e => e.IsVoready).HasColumnName("IsVOReady");

                entity.Property(e => e.ListenerCharacterResourceId).HasColumnName("ListenerCharacterResourceID");

                entity.Property(e => e.LocalizedVersionId).HasColumnName("LocalizedVersionID");

                entity.Property(e => e.MajorEditOnUtc)
                    .HasColumnName("MajorEditOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.MajorEditResourceVersionId).HasColumnName("MajorEditResourceVersionID");

                entity.Property(e => e.MinorEditOnUtc)
                    .HasColumnName("MinorEditOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.MinorEditResourceVersionId).HasColumnName("MinorEditResourceVersionID");

                entity.Property(e => e.PreviousResourceVersionId).HasColumnName("PreviousResourceVersionID");

                entity.Property(e => e.RecordingTypeId).HasColumnName("RecordingTypeID");

                entity.Property(e => e.StringTypeId).HasColumnName("StringTypeID");

                entity.Property(e => e.Text).IsRequired();

                entity.HasOne(d => d.ActorIntensityStringVoenum)
                    .WithMany(p => p.TResourceVersionStringActorIntensityStringVoenum)
                    .HasForeignKey(d => d.ActorIntensityStringVoenumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersionString_ActorIntensityStringVOEnumID");

                entity.HasOne(d => d.ActorVolumeStringVoenum)
                    .WithMany(p => p.TResourceVersionStringActorVolumeStringVoenum)
                    .HasForeignKey(d => d.ActorVolumeStringVoenumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersionString_ActorVolumeStringVOEnumID");

                entity.HasOne(d => d.RecordingType)
                    .WithMany(p => p.TResourceVersionString)
                    .HasForeignKey(d => d.RecordingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersionString_RecordingTypeID");

                entity.HasOne(d => d.ResourceVersion)
                    .WithMany(p => p.TResourceVersionString)
                    .HasForeignKey(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersionString_ResourceVersionID");

                entity.HasOne(d => d.String)
                    .WithMany(p => p.TResourceVersionString)
                    .HasForeignKey(d => d.StringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersionString_StringID");

                entity.HasOne(d => d.StringType)
                    .WithMany(p => p.TResourceVersionString)
                    .HasForeignKey(d => d.StringTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersionString_StringTypeID");

                entity.HasOne(d => d.TResourceVersionStringNavigation)
                    .WithMany(p => p.InverseTResourceVersionStringNavigation)
                    .HasForeignKey(d => new { d.PreviousResourceVersionId, d.StringId })
                    .HasConstraintName("FK_t_ResourceVersionString_PreviousResourceVersionID");
            });

            modelBuilder.Entity<TResourceVersionStringComment>(entity =>
            {
                entity.HasKey(e => new { e.ResourceVersionId, e.StringId });

                entity.ToTable("t_ResourceVersionStringComment");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.EditorComment).IsRequired();

                entity.Property(e => e.Vocomment)
                    .IsRequired()
                    .HasColumnName("VOComment");

                entity.HasOne(d => d.TResourceVersionString)
                    .WithOne(p => p.TResourceVersionStringComment)
                    .HasForeignKey<TResourceVersionStringComment>(d => new { d.ResourceVersionId, d.StringId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersionStringComment_ResourceVersionIDStringID");
            });

            modelBuilder.Entity<TResourceVersionStringGrammar>(entity =>
            {
                entity.HasKey(e => new { e.ResourceVersionId, e.StringId });

                entity.ToTable("t_ResourceVersionStringGrammar");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.ModifierPositionId).HasColumnName("ModifierPositionID");

                entity.Property(e => e.PhraseElementId).HasColumnName("PhraseElementID");

                entity.Property(e => e.PhraseTemplateId).HasColumnName("PhraseTemplateID");

                entity.Property(e => e.WordClassId).HasColumnName("WordClassID");

                entity.HasOne(d => d.TResourceVersionString)
                    .WithOne(p => p.TResourceVersionStringGrammar)
                    .HasForeignKey<TResourceVersionStringGrammar>(d => new { d.ResourceVersionId, d.StringId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersionStringGrammar_ResourceVersionIDStringID");
            });

            modelBuilder.Entity<TResourceVersionStringSpeaker>(entity =>
            {
                entity.HasKey(e => new { e.ResourceVersionId, e.StringId, e.CharacterResourceId });

                entity.ToTable("t_ResourceVersionStringSpeaker");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.CharacterResourceId).HasColumnName("CharacterResourceID");

                entity.Property(e => e.IsVoeligible).HasColumnName("IsVOEligible");

                entity.Property(e => e.IsVoreRecord).HasColumnName("IsVOReRecord");

                entity.Property(e => e.VorequestOnUtc)
                    .HasColumnName("VORequestOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.VorequestResourceVersionId).HasColumnName("VORequestResourceVersionID");

                entity.HasOne(d => d.CharacterResource)
                    .WithMany(p => p.TResourceVersionStringSpeaker)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.CharacterResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersionStringSpeaker_CharacterResourceID");

                entity.HasOne(d => d.TResourceVersionString)
                    .WithMany(p => p.TResourceVersionStringSpeaker)
                    .HasForeignKey(d => new { d.ResourceVersionId, d.StringId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_ResourceVersionStringSpeaker_ResourceVersionIDStringID");
            });

            modelBuilder.Entity<TString>(entity =>
            {
                entity.HasKey(e => e.StringId);

                entity.ToTable("t_String");

                entity.HasIndex(e => e.FriendlyStringId)
                    .HasName("IX-t_String_FriendlyStringID")
                    .IsUnique()
                    .HasFilter("([FriendlyStringID]>(0))");

                entity.HasIndex(e => new { e.StringUniqueId, e.FriendlyStringId, e.StringId })
                    .HasName("IX_t_String_ByFriendlyStringID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.FriendlyStringId).HasColumnName("FriendlyStringID");

                entity.Property(e => e.SourceStringUniqueId)
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.StringUniqueId)
                    .IsRequired()
                    .HasColumnName("StringUniqueID")
                    .HasMaxLength(48)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TStringCloneEvent>(entity =>
            {
                entity.HasKey(e => e.StringCloneEventId);

                entity.ToTable("t_StringCloneEvent");

                entity.HasIndex(e => e.EventGuid)
                    .HasName("UK_t_StringCloneEvent_EventGuid")
                    .IsUnique();

                entity.HasIndex(e => e.IsValid);

                entity.HasIndex(e => e.ProcessedOnUtc);

                entity.Property(e => e.StringCloneEventId).HasColumnName("StringCloneEventID");

                entity.Property(e => e.CloneResourceVersionId).HasColumnName("CloneResourceVersionID");

                entity.Property(e => e.CloneStringUniqueId)
                    .IsRequired()
                    .HasColumnName("CloneStringUniqueID")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ProcessedOnUtc)
                    .HasColumnName("ProcessedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceResourceId).HasColumnName("SourceResourceID");

                entity.Property(e => e.SourceResourceUniqueId)
                    .IsRequired()
                    .HasColumnName("SourceResourceUniqueID")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.SourceResourceVersionId).HasColumnName("SourceResourceVersionID");

                entity.Property(e => e.SourceStringUniqueId)
                    .IsRequired()
                    .HasColumnName("SourceStringUniqueID")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.HasOne(d => d.CloneResourceVersion)
                    .WithMany(p => p.TStringCloneEventCloneResourceVersion)
                    .HasForeignKey(d => d.CloneResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StringCloneEvent_NewResourceVersionID");

                entity.HasOne(d => d.CloneString)
                    .WithMany(p => p.TStringCloneEventCloneString)
                    .HasForeignKey(d => d.CloneStringId)
                    .HasConstraintName("FK_t_StringCloneEvent_CloneStringID");

                entity.HasOne(d => d.SourceResource)
                    .WithMany(p => p.TStringCloneEvent)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.SourceResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_StringCloneEvent_OldResourceID");

                entity.HasOne(d => d.SourceResourceVersion)
                    .WithMany(p => p.TStringCloneEventSourceResourceVersion)
                    .HasForeignKey(d => d.SourceResourceVersionId)
                    .HasConstraintName("FK_StringCloneEvent_OldResourceVersionID");

                entity.HasOne(d => d.SourceString)
                    .WithMany(p => p.TStringCloneEventSourceString)
                    .HasForeignKey(d => d.SourceStringId)
                    .HasConstraintName("FK_t_StringCloneEvent_SourceStringID");
            });

            modelBuilder.Entity<TStringCloneTriage>(entity =>
            {
                entity.HasKey(e => e.StringCloneTriageId);

                entity.ToTable("t_StringCloneTriage");

                entity.HasIndex(e => new { e.StringCloneEventId, e.StringCloneTriageProfileId })
                    .HasName("IX_t_StringCloneTriage_EventIDProfileID")
                    .IsUnique();

                entity.Property(e => e.StringCloneTriageId).HasColumnName("StringCloneTriageID");

                entity.Property(e => e.StringCloneEventId).HasColumnName("StringCloneEventID");

                entity.Property(e => e.StringCloneTriageProfileId).HasColumnName("StringCloneTriageProfileID");

                entity.Property(e => e.StringCloneTriageSessionId).HasColumnName("StringCloneTriageSessionID");

                entity.HasOne(d => d.StringCloneEvent)
                    .WithMany(p => p.TStringCloneTriage)
                    .HasForeignKey(d => d.StringCloneEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_StringCloneTriage_StringCloneEventID");

                entity.HasOne(d => d.StringCloneTriageProfile)
                    .WithMany(p => p.TStringCloneTriage)
                    .HasForeignKey(d => d.StringCloneTriageProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_StringCloneTriage_StringCloneTriageProfileID");

                entity.HasOne(d => d.StringCloneTriageSession)
                    .WithMany(p => p.TStringCloneTriage)
                    .HasForeignKey(d => d.StringCloneTriageSessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_StringCloneTriage_StringCloneTriageSessionID");
            });

            modelBuilder.Entity<TStringCloneTriageProfile>(entity =>
            {
                entity.HasKey(e => e.StringCloneTriageProfileId);

                entity.ToTable("t_StringCloneTriageProfile");

                entity.Property(e => e.StringCloneTriageProfileId)
                    .HasColumnName("StringCloneTriageProfileID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ManageMasterLanguageVo).HasColumnName("ManageMasterLanguageVO");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.HasOne(d => d.TranslationPartner)
                    .WithMany(p => p.TStringCloneTriageProfile)
                    .HasForeignKey(d => d.TranslationPartnerId)
                    .HasConstraintName("FK_t_StringCloneTriageProfile_TranslationPartnerID");
            });

            modelBuilder.Entity<TStringCloneTriageSession>(entity =>
            {
                entity.HasKey(e => e.StringCloneTriageSessionId);

                entity.ToTable("t_StringCloneTriageSession");

                entity.Property(e => e.StringCloneTriageSessionId).HasColumnName("StringCloneTriageSessionID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.TriagedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.TriagedOnUtc)
                    .HasColumnName("TriagedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<TStringHistory>(entity =>
            {
                entity.HasKey(e => e.StringHistoryId);

                entity.ToTable("t_StringHistory");

                entity.Property(e => e.StringHistoryId).HasColumnName("StringHistoryID");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.FriendlyStringId).HasColumnName("FriendlyStringID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.StringUniqueId)
                    .IsRequired()
                    .HasColumnName("StringUniqueID")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.HasOne(d => d.String)
                    .WithMany(p => p.TStringHistory)
                    .HasForeignKey(d => d.StringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_StringHistory_StringID");
            });

            modelBuilder.Entity<TStringImportCache>(entity =>
            {
                entity.HasKey(e => new { e.StringId, e.LocalizedVersionId, e.VariantId, e.LanguageId, e.PlayerVariantId, e.BranchId, e.VoscriptId })
                    .HasName("PK__t_String__E6E608D03C67CB5E");

                entity.ToTable("t_StringImportCache", "vope");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.LocalizedVersionId).HasColumnName("LocalizedVersionID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.PlayerVariantId).HasColumnName("PlayerVariantID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.VoscriptId).HasColumnName("VOScriptID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FriendlyStringId).HasColumnName("FriendlyStringID");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.Vocomment)
                    .IsRequired()
                    .HasColumnName("VOComment");
            });

            modelBuilder.Entity<TStringRemovalType>(entity =>
            {
                entity.HasKey(e => e.RemovalTypeId)
                    .HasName("PK__t_String__5D639C1E469D7149");

                entity.ToTable("t_StringRemovalType");

                entity.Property(e => e.RemovalTypeId).HasColumnName("RemovalTypeID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TStringType>(entity =>
            {
                entity.HasKey(e => e.StringTypeId);

                entity.ToTable("t_StringType");

                entity.Property(e => e.StringTypeId).HasColumnName("StringTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectUniqueId).HasColumnName("ProjectUniqueID");
            });

            modelBuilder.Entity<TStringVoenum>(entity =>
            {
                entity.HasKey(e => e.StringVoenumId);

                entity.ToTable("t_StringVOEnum");

                entity.Property(e => e.StringVoenumId).HasColumnName("StringVOEnumID");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTranslationPartner>(entity =>
            {
                entity.HasKey(e => e.TranslationPartnerId);

                entity.ToTable("t_TranslationPartner", "loc");

                entity.Property(e => e.TranslationPartnerId)
                    .HasColumnName("TranslationPartnerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TUniqueFeminineTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.BranchId, e.StringId });

                entity.ToTable("t_UniqueFeminineTranslation", "loc");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.FeminineImportSessionStringId).HasColumnName("FeminineImportSessionStringID");

                entity.Property(e => e.MasculineImportSessionStringId).HasColumnName("MasculineImportSessionStringID");
            });

            modelBuilder.Entity<TUserLog>(entity =>
            {
                entity.HasKey(e => e.UserLogId);

                entity.ToTable("t_UserLog", "log");

                entity.Property(e => e.UserLogId).HasColumnName("UserLogID");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationSession)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Exception)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoggedOnUtc)
                    .HasColumnName("LoggedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.StackTrace)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Thread)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<TVariant>(entity =>
            {
                entity.HasKey(e => e.VariantId);

                entity.ToTable("t_Variant", "loc");

                entity.Property(e => e.VariantId)
                    .HasColumnName("VariantID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TVoice>(entity =>
            {
                entity.HasKey(e => e.ResourceVersionId);

                entity.ToTable("t_Voice");

                entity.Property(e => e.ResourceVersionId)
                    .HasColumnName("ResourceVersionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.VopipelineFilenameVariant)
                    .IsRequired()
                    .HasColumnName("VOPipelineFilenameVariant");

                entity.Property(e => e.VoproductionFilenameCategory)
                    .IsRequired()
                    .HasColumnName("VOProductionFilenameCategory");

                entity.HasOne(d => d.DefaultVoiceForCharacterResource)
                    .WithMany(p => p.TVoice)
                    .HasPrincipalKey(p => p.ResourceId)
                    .HasForeignKey(d => d.DefaultVoiceForCharacterResourceId)
                    .HasConstraintName("FK_t_Voice_DefaultVoiceForCharacterResourceId");

                entity.HasOne(d => d.ResourceVersion)
                    .WithOne(p => p.TVoice)
                    .HasForeignKey<TVoice>(d => d.ResourceVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_Voice_ResourceVersionID");
            });

            modelBuilder.Entity<TVoprepInstance>(entity =>
            {
                entity.HasKey(e => new { e.PrepToken, e.VoscriptId });

                entity.ToTable("t_VOPrepInstance", "vo");

                entity.Property(e => e.PrepToken)
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.VoscriptId).HasColumnName("VOScriptID");

                entity.Property(e => e.ParentResourceVersionId).HasColumnName("ParentResourceVersionID");

                entity.Property(e => e.Verbosity)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VoiceResourceVersionId).HasColumnName("VoiceResourceVersionID");

                entity.Property(e => e.VoprepInstanceId)
                    .HasColumnName("VOPrepInstanceID")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Voscript)
                    .WithMany(p => p.TVoprepInstance)
                    .HasForeignKey(d => d.VoscriptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_VOPrepInstance_VOScriptID");
            });

            modelBuilder.Entity<TVoprepInstanceString>(entity =>
            {
                entity.HasKey(e => e.VoprepInstanceStringId)
                    .IsClustered(false);

                entity.ToTable("t_VOPrepInstanceString", "vo");

                entity.HasIndex(e => new { e.PrepToken, e.VoscriptId })
                    .HasName("IX_t_VOPrepInstanceString_clustered")
                    .IsClustered();

                entity.Property(e => e.VoprepInstanceStringId).HasColumnName("VOPrepInstanceStringID");

                entity.Property(e => e.ImportSessionStringId).HasColumnName("ImportSessionStringID");

                entity.Property(e => e.PrepToken)
                    .IsRequired()
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.VofileName)
                    .IsRequired()
                    .HasColumnName("VOFileName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VoscriptId).HasColumnName("VOScriptID");

                entity.HasOne(d => d.TVoprepInstance)
                    .WithMany(p => p.TVoprepInstanceString)
                    .HasForeignKey(d => new { d.PrepToken, d.VoscriptId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_VOPrepInstanceString_PrepInstance");
            });

            modelBuilder.Entity<TVoscript>(entity =>
            {
                entity.HasKey(e => e.VoscriptId)
                    .HasName("PK_VOScript");

                entity.ToTable("t_VOScript", "vo");

                entity.HasIndex(e => new { e.ParentResourceId, e.VoiceResourceId, e.VoscriptId })
                    .HasName("IX_t_VOScript_ResourceIDs");

                entity.Property(e => e.VoscriptId).HasColumnName("VOScriptID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ParentResourceId).HasColumnName("ParentResourceID");

                entity.Property(e => e.VoiceResourceId).HasColumnName("VoiceResourceID");
            });

            modelBuilder.Entity<TVoscriptCache>(entity =>
            {
                entity.HasKey(e => new { e.VoscriptId, e.LanguageId, e.VariantId, e.StringId, e.LocalizedVersionId, e.BranchId })
                    .HasName("PK__t_VOScri__9A50CB8017A81A9F");

                entity.ToTable("t_VOScriptCache", "vo");

                entity.Property(e => e.VoscriptId).HasColumnName("VOScriptID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.LocalizedVersionId).HasColumnName("LocalizedVersionID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CacheUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.CompareDate).HasColumnType("datetime");

                entity.Property(e => e.HasAprintedVersion).HasColumnName("HasAPrintedVersion");

                entity.Property(e => e.IsVoready).HasColumnName("IsVOReady");

                entity.Property(e => e.MaxVoscriptInstanceId).HasColumnName("MaxVOScriptInstanceID");

                entity.Property(e => e.ParentResourceUniqueId)
                    .HasColumnName("ParentResourceUniqueID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.RecordingRequestedOn).HasColumnType("datetime");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.VofileName)
                    .HasColumnName("VOFileName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceResourceId).HasColumnName("VoiceResourceID");

                entity.Property(e => e.VoiceResourceUniqueId)
                    .HasColumnName("VoiceResourceUniqueID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.VoscriptInstanceId).HasColumnName("VOScriptInstanceID");
            });

            modelBuilder.Entity<TVoscriptCacheStringProcessingQueue>(entity =>
            {
                entity.HasKey(e => e.StringId)
                    .HasName("PK__t_VOScri__12E93AE93661ABE9");

                entity.ToTable("t_VOScriptCache_StringProcessingQueue", "vo");

                entity.Property(e => e.StringId)
                    .HasColumnName("StringID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TVoscriptGenerationSession>(entity =>
            {
                entity.HasKey(e => e.VoscriptGenerationSessionId);

                entity.ToTable("t_VOScriptGenerationSession", "vo");

                entity.Property(e => e.VoscriptGenerationSessionId).HasColumnName("VOScriptGenerationSessionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.GenerationAnchorUtc)
                    .HasColumnName("GenerationAnchorUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenerationComment).IsRequired();

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.HasOne(d => d.TranslationPartner)
                    .WithMany(p => p.TVoscriptGenerationSession)
                    .HasForeignKey(d => d.TranslationPartnerId)
                    .HasConstraintName("fk_vo_t_VOScriptGenerationSession_loc_t_TranslationPartner");
            });

            modelBuilder.Entity<TVoscriptInstance>(entity =>
            {
                entity.HasKey(e => e.VoscriptInstanceId);

                entity.ToTable("t_VOScriptInstance", "vo");

                entity.HasIndex(e => new { e.VoscriptGenerationSessionId, e.VoscriptId })
                    .HasName("IX_t_VOScriptInstance_SessionScripts")
                    .IsUnique();

                entity.Property(e => e.VoscriptInstanceId).HasColumnName("VOScriptInstanceID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.ParentResourceVersionId).HasColumnName("ParentResourceVersionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Verbosity)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VoiceResourceVersionId).HasColumnName("VoiceResourceVersionID");

                entity.Property(e => e.VoscriptGenerationSessionId).HasColumnName("VOScriptGenerationSessionID");

                entity.Property(e => e.VoscriptId).HasColumnName("VOScriptID");

                entity.HasOne(d => d.VoscriptGenerationSession)
                    .WithMany(p => p.TVoscriptInstance)
                    .HasForeignKey(d => d.VoscriptGenerationSessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_VOScriptInstance_VOScriptGenerationSessionID");

                entity.HasOne(d => d.Voscript)
                    .WithMany(p => p.TVoscriptInstance)
                    .HasForeignKey(d => d.VoscriptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_VOScriptInstance_VOScriptID");
            });

            modelBuilder.Entity<TVoscriptInstanceString>(entity =>
            {
                entity.HasKey(e => e.VoscriptInstanceStringId);

                entity.ToTable("t_VOScriptInstanceString", "vo");

                entity.HasIndex(e => new { e.VoscriptInstanceId, e.StringId, e.VariantId })
                    .HasName("IX_t_VOScriptInstanceString_InstanceStringVariant")
                    .IsUnique();

                entity.Property(e => e.VoscriptInstanceStringId).HasColumnName("VOScriptInstanceStringID");

                entity.Property(e => e.CompareDate).HasColumnType("datetime");

                entity.Property(e => e.ImportSessionStringId).HasColumnName("ImportSessionStringID");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.LastModifiedOnUtc)
                    .HasColumnName("LastModifiedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.ParentResourceVersionId).HasColumnName("ParentResourceVersionID");

                entity.Property(e => e.PreviousVoscriptInstanceStringId).HasColumnName("PreviousVOScriptInstanceStringID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.VofileName)
                    .IsRequired()
                    .HasColumnName("VOFileName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VoscriptInstanceId).HasColumnName("VOScriptInstanceID");

                entity.HasOne(d => d.PreviousVoscriptInstanceString)
                    .WithMany(p => p.InversePreviousVoscriptInstanceString)
                    .HasForeignKey(d => d.PreviousVoscriptInstanceStringId)
                    .HasConstraintName("FK_t_VOScriptInstanceString_PrevioustVOScriptInstanceStringID");

                entity.HasOne(d => d.VoscriptInstance)
                    .WithMany(p => p.TVoscriptInstanceString)
                    .HasForeignKey(d => d.VoscriptInstanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_VOScriptInstanceString_VOScriptInstanceID");

                entity.HasOne(d => d.TResourceVersionString)
                    .WithMany(p => p.TVoscriptInstanceString)
                    .HasForeignKey(d => new { d.ParentResourceVersionId, d.StringId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_VOScriptInstanceString_ResourceVersionString");
            });

            modelBuilder.Entity<TVoscriptInstanceStringTriage>(entity =>
            {
                entity.HasKey(e => e.VoscriptInstanceStringTriageId);

                entity.ToTable("t_VOScriptInstanceStringTriage", "vo");

                entity.Property(e => e.VoscriptInstanceStringTriageId).HasColumnName("VOScriptInstanceStringTriageID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CompareDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.VoscriptInstanceStringId).HasColumnName("VOScriptInstanceStringID");

                entity.Property(e => e.VoscriptTriageActionId).HasColumnName("VOScriptTriageActionID");

                entity.HasOne(d => d.VoscriptInstanceString)
                    .WithMany(p => p.TVoscriptInstanceStringTriage)
                    .HasForeignKey(d => d.VoscriptInstanceStringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_VOScriptInstanceStringTriage_VOScriptInstanceStringID");

                entity.HasOne(d => d.VoscriptTriageAction)
                    .WithMany(p => p.TVoscriptInstanceStringTriage)
                    .HasForeignKey(d => d.VoscriptTriageActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_VOScriptInstanceStringTriage_VOScriptTriageActionID");
            });

            modelBuilder.Entity<TVoscriptTriageAction>(entity =>
            {
                entity.HasKey(e => e.VoscriptTriageActionId);

                entity.ToTable("t_VOScriptTriageAction", "vo");

                entity.Property(e => e.VoscriptTriageActionId)
                    .HasColumnName("VOScriptTriageActionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TVosession>(entity =>
            {
                entity.HasKey(e => e.VosessionId);

                entity.ToTable("t_VOSession", "vo");

                entity.Property(e => e.VosessionId).HasColumnName("VOSessionID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            });

            modelBuilder.Entity<TVosessionContactInfo>(entity =>
            {
                entity.HasKey(e => e.VosessionContactInfoId);

                entity.ToTable("t_VOSessionContactInfo", "vo");

                entity.Property(e => e.VosessionContactInfoId).HasColumnName("VOSessionContactInfoID");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TVosessionData>(entity =>
            {
                entity.HasKey(e => e.VosessionDataId)
                    .IsClustered(false);

                entity.ToTable("t_VOSessionData", "vo");

                entity.HasIndex(e => new { e.Status, e.VosessionId })
                    .HasName("IX_t_VOSessionData_StatusSession")
                    .IsClustered();

                entity.Property(e => e.VosessionDataId).HasColumnName("VOSessionDataID");

                entity.Property(e => e.Actor)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ActorInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.ActorInvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ChecklistNotes).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.InternalNotes).IsRequired();

                entity.Property(e => e.SessionDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Studio)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.StudioInvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.StudioInvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.VosessionId).HasColumnName("VOSessionID");

                entity.HasOne(d => d.Vosession)
                    .WithMany(p => p.TVosessionData)
                    .HasForeignKey(d => d.VosessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_VOSessionData_VOSessionID");
            });

            modelBuilder.Entity<TVosessionScript>(entity =>
            {
                entity.HasKey(e => e.VosessionScriptId)
                    .IsClustered(false);

                entity.ToTable("t_VOSessionScript", "vo");

                entity.HasIndex(e => new { e.Status, e.VosessionId, e.ScriptId })
                    .HasName("IX_t_VOSessionScript_StatusSessionScript")
                    .IsClustered();

                entity.Property(e => e.VosessionScriptId).HasColumnName("VOSessionScriptID");

                entity.Property(e => e.ChecklistNotes).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CustomScriptName).HasMaxLength(256);

                entity.Property(e => e.InternalNotes).IsRequired();

                entity.Property(e => e.ScriptId).HasColumnName("ScriptID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VoscriptInstanceId).HasColumnName("VOScriptInstanceID");

                entity.Property(e => e.VosessionId).HasColumnName("VOSessionID");

                entity.HasOne(d => d.VoscriptInstance)
                    .WithMany(p => p.TVosessionScript)
                    .HasForeignKey(d => d.VoscriptInstanceId)
                    .HasConstraintName("FK_VOScriptInstanceID_VOScriptInstanceID");

                entity.HasOne(d => d.Vosession)
                    .WithMany(p => p.TVosessionScript)
                    .HasForeignKey(d => d.VosessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_t_VOSessionScript_VOSessionID");
            });

            modelBuilder.Entity<TVostringData>(entity =>
            {
                entity.HasKey(e => e.VostringDataId);

                entity.ToTable("t_VOStringData", "vo");

                entity.Property(e => e.VostringDataId).HasColumnName("VOStringDataID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.VoproductionComment)
                    .IsRequired()
                    .HasColumnName("VOProductionComment");
            });

            modelBuilder.Entity<TWordAndLineCountData>(entity =>
            {
                entity.HasKey(e => e.WordAndLineCountDataId);

                entity.ToTable("t_WordAndLineCountData");

                entity.Property(e => e.WordAndLineCountDataId).HasColumnName("WordAndLineCountDataID");

                entity.Property(e => e.FriendlyStringId).HasColumnName("FriendlyStringID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.LastEnglishPrintedOnUtc)
                    .HasColumnName("LastEnglishPrintedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastEnglishReceivedOn).HasColumnType("datetime");

                entity.Property(e => e.LastForeignPrintedOnUtc)
                    .HasColumnName("LastForeignPrintedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastImportedOnUtc)
                    .HasColumnName("LastImportedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastSentForTranslationOnUtc)
                    .HasColumnName("LastSentForTranslationOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductionState)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ScopeSubTag).IsUnicode(false);

                entity.Property(e => e.ScopeTag).IsUnicode(false);

                entity.Property(e => e.ScriptResource)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.Voeligible).HasColumnName("VOEligible");

                entity.Property(e => e.Voice)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Voready).HasColumnName("VOReady");

                entity.Property(e => e.VoscriptId).HasColumnName("VOScriptID");

                entity.Property(e => e.WritingWorkflowState)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TWritingWorkflowState>(entity =>
            {
                entity.HasKey(e => e.WritingWorkflowStateId);

                entity.ToTable("t_WritingWorkflowState");

                entity.Property(e => e.WritingWorkflowStateId)
                    .HasColumnName("WritingWorkflowStateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(48)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VCharacterCasting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CharacterCasting", "vo");

                entity.Property(e => e.Comments).IsRequired();

                entity.Property(e => e.CurrentActor).IsRequired();

                entity.Property(e => e.CurrentCastingActorId).HasColumnName("CurrentCastingActorID");

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.VoiceResourceGuid)
                    .IsRequired()
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceResourceId).HasColumnName("VoiceResourceID");
            });

            modelBuilder.Entity<VCharacterGenderRace>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CharacterGenderRace");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Race)
                    .IsRequired()
                    .HasMaxLength(48);
            });

            modelBuilder.Entity<VCharacterVolineCountsByDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CharacterVOLineCountsByDate", "trend");

                entity.Property(e => e.Character).IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.VolineCount).HasColumnName("VOLineCount");
            });

            modelBuilder.Entity<VCurrentCharacterVoiceAssociation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CurrentCharacterVoiceAssociation");

                entity.Property(e => e.CharacterResourceId).HasColumnName("CharacterResourceID");

                entity.Property(e => e.CharacterResourceVersionId).HasColumnName("CharacterResourceVersionID");

                entity.Property(e => e.VoiceResourceId).HasColumnName("VoiceResourceID");

                entity.Property(e => e.VoiceResourceVersionId).HasColumnName("VoiceResourceVersionID");
            });

            modelBuilder.Entity<VCurrentMainBranchMasterText>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CurrentMainBranchMasterText");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.FriendlyStringId).HasColumnName("FriendlyStringID");

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<VGrammarNounGender>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_GrammarNounGender");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.EnumerationId).HasColumnName("EnumerationID");

                entity.Property(e => e.EnumerationName).IsRequired();
            });

            modelBuilder.Entity<VGrammarNounNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_GrammarNounNumber");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.EnumerationId).HasColumnName("EnumerationID");

                entity.Property(e => e.EnumerationName).IsRequired();
            });

            modelBuilder.Entity<VGrammarPhraseElement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_GrammarPhraseElement");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.EnumerationId).HasColumnName("EnumerationID");

                entity.Property(e => e.EnumerationName).IsRequired();
            });

            modelBuilder.Entity<VGrammarPhraseTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_GrammarPhraseTemplate");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.EnumerationId).HasColumnName("EnumerationID");

                entity.Property(e => e.EnumerationName).IsRequired();
            });

            modelBuilder.Entity<VGrammarWordClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_GrammarWordClass");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.EnumerationId).HasColumnName("EnumerationID");

                entity.Property(e => e.EnumerationName).IsRequired();
            });

            modelBuilder.Entity<VHighLevelExportProgressByConversationLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_HighLevelExportProgressByConversationLines", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VHighLevelExportProgressByConversationLinesAndWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_HighLevelExportProgressByConversationLinesAndWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VHighLevelExportProgressByConversationWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_HighLevelExportProgressByConversationWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VHighLevelExportProgressByLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_HighLevelExportProgressByLines", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VHighLevelExportProgressByLinesAndWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_HighLevelExportProgressByLinesAndWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VHighLevelExportProgressByNonConversationLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_HighLevelExportProgressByNonConversationLines", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VHighLevelExportProgressByNonConversationLinesAndWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_HighLevelExportProgressByNonConversationLinesAndWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VHighLevelExportProgressByNonConversationWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_HighLevelExportProgressByNonConversationWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VHighLevelExportProgressByWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_HighLevelExportProgressByWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VImportSessionText>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ImportSessionText", "loc");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.FriendlyStringId).HasColumnName("FriendlyStringID");

                entity.Property(e => e.ImportSessionStringId).HasColumnName("ImportSessionStringID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LocalizedVersionId).HasColumnName("LocalizedVersionID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.VariantId).HasColumnName("VariantID");
            });

            modelBuilder.Entity<VLocalizationImportProgressByConversationLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LocalizationImportProgressByConversationLines", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLocalizationImportProgressByConversationLinesAndWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LocalizationImportProgressByConversationLinesAndWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLocalizationImportProgressByConversationWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LocalizationImportProgressByConversationWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLocalizationImportProgressByLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LocalizationImportProgressByLines", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLocalizationImportProgressByLinesAndWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LocalizationImportProgressByLinesAndWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLocalizationImportProgressByNonConversationLines>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LocalizationImportProgressByNonConversationLines", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLocalizationImportProgressByNonConversationLinesAndWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LocalizationImportProgressByNonConversationLinesAndWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLocalizationImportProgressByNonConversationWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LocalizationImportProgressByNonConversationWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VLocalizationImportProgressByWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_LocalizationImportProgressByWords", "trend");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LanguageTag)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TranslationPartnerName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VNonUniqueCharacterNames>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_NonUniqueCharacterNames");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CharacterName).IsRequired();

                entity.Property(e => e.ResourceFolder)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VPrintedStringTextVersions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_PrintedStringTextVersions");

                entity.Property(e => e.Actor)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.FriendlyStringId).HasColumnName("FriendlyStringID");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate).HasColumnType("datetime");

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<VResourceVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ResourceVersion");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ChangelistId).HasColumnName("ChangelistID");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnName("CreatedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataImportSessionId).HasColumnName("DataImportSessionID");

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ModelTypeId).HasColumnName("ModelTypeID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousResourceVersionId).HasColumnName("PreviousResourceVersionID");

                entity.Property(e => e.ProductionStateId).HasColumnName("ProductionStateID");

                entity.Property(e => e.RepositoryPath).IsUnicode(false);

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ResourceTypeId).HasColumnName("ResourceTypeID");

                entity.Property(e => e.ResourceUniqueId)
                    .IsRequired()
                    .HasColumnName("ResourceUniqueID")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceVersionId).HasColumnName("ResourceVersionID");

                entity.Property(e => e.ScopeSubTag).IsUnicode(false);

                entity.Property(e => e.ScopeTag).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeTag).IsUnicode(false);

                entity.Property(e => e.WritingPointOfContact).IsUnicode(false);

                entity.Property(e => e.WritingWorkflowStateId).HasColumnName("WritingWorkflowStateID");
            });

            modelBuilder.Entity<VScopeByConversationType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ScopeByConversationType", "trend");

                entity.Property(e => e.Build).IsUnicode(false);

                entity.Property(e => e.DataDirectory).IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScopeSubTag).IsUnicode(false);

                entity.Property(e => e.ScopeTag).IsUnicode(false);

                entity.Property(e => e.TotalNonVolinesActual).HasColumnName("TotalNonVOLinesActual");

                entity.Property(e => e.TotalNonVowordsActual).HasColumnName("TotalNonVOWordsActual");
            });

            modelBuilder.Entity<VScopeByLineAverage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ScopeByLineAverage", "trend");

                entity.Property(e => e.Build).IsUnicode(false);

                entity.Property(e => e.DataDirectory).IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Group).IsUnicode(false);
            });

            modelBuilder.Entity<VScopeByWritingWorkflow>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ScopeByWritingWorkflow", "trend");

                entity.Property(e => e.Build).IsUnicode(false);

                entity.Property(e => e.DataDirectory).IsUnicode(false);

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.LockedForVowordCount).HasColumnName("LockedForVOWordCount");

                entity.Property(e => e.ScopeSubTag).IsUnicode(false);

                entity.Property(e => e.ScopeTag).IsUnicode(false);
            });

            modelBuilder.Entity<VStringCloneTriageInformation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_StringCloneTriageInformation");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.SourceStringId).HasColumnName("SourceStringID");

                entity.Property(e => e.StringCloneTriageId).HasColumnName("StringCloneTriageID");

                entity.Property(e => e.TargetStringId).HasColumnName("TargetStringID");

                entity.Property(e => e.TranslationPartnerId).HasColumnName("TranslationPartnerID");

                entity.Property(e => e.TriagedOnUtc)
                    .HasColumnName("TriagedOnUTC")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VTranslationImportHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_TranslationImportHistory");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentText).IsRequired();

                entity.Property(e => e.ExportedText).IsRequired();

                entity.Property(e => e.ImportComment).IsRequired();

                entity.Property(e => e.ImportedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ImportedOnLocal).HasColumnType("datetime");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneticProcessingText).IsRequired();

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.Translation).IsRequired();

                entity.Property(e => e.TranslationPartnerTrackingId).HasColumnName("TranslationPartnerTrackingID");

                entity.Property(e => e.Variant)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VVoiceVolineCountsByDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_VoiceVOLineCountsByDate", "trend");

                entity.Property(e => e.DateUtc)
                    .HasColumnName("DateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsPlayer).IsUnicode(false);

                entity.Property(e => e.Voice).IsUnicode(false);

                entity.Property(e => e.VolineCount).HasColumnName("VOLineCount");
            });

            modelBuilder.Entity<VVoscriptInstanceStringText>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_VOScriptInstanceStringText", "vo");

                entity.Property(e => e.VoscriptInstanceStringId).HasColumnName("VOScriptInstanceStringID");
            });

            modelBuilder.Entity<VWebApiAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_WebApiAccess");

                entity.Property(e => e.AccessedOnUtc)
                    .HasColumnName("AccessedOnUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClientAddress)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.QueryString).IsRequired();

                entity.Property(e => e.RequestPath).IsRequired();

                entity.Property(e => e.Url).IsRequired();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
