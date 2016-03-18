using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Old.Concretes
{
    public partial class FosAgroContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=106PC0013\SQLEXPRESS;Database=FosAgro;Trusted_Connection=True;;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BkServiceFastTasks>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.HasOne(d => d.FastTaskStatus).WithMany(p => p.BkServiceFastTasks).HasForeignKey(d => d.FastTaskStatusId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.FastTaskType).WithMany(p => p.BkServiceFastTasks).HasForeignKey(d => d.FastTaskTypeId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<BkServiceShedullerTasks>(entity =>
            {
                entity.HasIndex(e => new { e.ShedullerTaskTypeId, e.RefObjId }).HasName("IX_Type_RefObj");

                entity.Property(e => e.LastExecDate).HasColumnType("datetime");

                entity.Property(e => e.LastExecEndDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.NextExecDate).HasColumnType("datetime");

                entity.Property(e => e.StartExecDate).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.ShedullerTaskPeriod).WithMany(p => p.BkServiceShedullerTasks).HasForeignKey(d => d.ShedullerTaskPeriodId);

                entity.HasOne(d => d.ShedullerTaskType).WithMany(p => p.BkServiceShedullerTasks).HasForeignKey(d => d.ShedullerTaskTypeId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.BkServiceShedullerTasks).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictDirectorsGroups>(entity =>
            {
                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictDirectorsGroups).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictDirectorsGroupsL>(entity =>
            {
                entity.HasKey(e => new { e.DirectorsGroupId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.DirectorsGroup).WithMany(p => p.DictDirectorsGroupsL).HasForeignKey(d => d.DirectorsGroupId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Language).WithMany(p => p.DictDirectorsGroupsL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictDirectorsGroupsL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictFastTasksStatuses>(entity =>
            {
                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictFastTasksStatuses).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictFastTasksStatusesL>(entity =>
            {
                entity.HasKey(e => new { e.FastTaskStatusId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.FastTaskStatus).WithMany(p => p.DictFastTasksStatusesL).HasForeignKey(d => d.FastTaskStatusId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Language).WithMany(p => p.DictFastTasksStatusesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictFastTasksStatusesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictFastTasksTypes>(entity =>
            {
                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictFastTasksTypes).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictFastTasksTypesL>(entity =>
            {
                entity.HasKey(e => new { e.FastTaskTypeId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.FastTaskType).WithMany(p => p.DictFastTasksTypesL).HasForeignKey(d => d.FastTaskTypeId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Language).WithMany(p => p.DictFastTasksTypesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictFastTasksTypesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictLanguages>(entity =>
            {
                entity.Property(e => e.Alias).HasMaxLength(10);

                entity.Property(e => e.IsDefault).HasDefaultValue(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictLanguages).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictMeetingsAlertsTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictMeetingsAlertsTypes).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictMeetingsAlertsTypesL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingAlertTypeId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.DictMeetingsAlertsTypesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingAlertType).WithMany(p => p.DictMeetingsAlertsTypesL).HasForeignKey(d => d.MeetingAlertTypeId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictMeetingsAlertsTypesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictMeetingsDirectoriesTypes>(entity =>
            {
                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictMeetingsDirectoriesTypes).HasForeignKey(d => d.UpdUserID).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictMeetingsDirectoriesTypesL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingDirectoryTypeId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.DictMeetingsDirectoriesTypesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingDirectoryType).WithMany(p => p.DictMeetingsDirectoriesTypesL).HasForeignKey(d => d.MeetingDirectoryTypeId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictMeetingsDirectoriesTypesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictMeetingsFormats>(entity =>
            {
                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictMeetingsFormats).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictMeetingsFormatsL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingFormatId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.DictMeetingsFormatsL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingFormat).WithMany(p => p.DictMeetingsFormatsL).HasForeignKey(d => d.MeetingFormatId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictMeetingsFormatsL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictMeetingsStatuses>(entity =>
            {
                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictMeetingsStatuses).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictMeetingsStatusesL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingStatusId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.DictMeetingsStatusesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingStatus).WithMany(p => p.DictMeetingsStatusesL).HasForeignKey(d => d.MeetingStatusId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictMeetingsStatusesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictMeetingsVotesStatuses>(entity =>
            {
                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictMeetingsVotesStatuses).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictMeetingsVotesStatusesL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingVoteStatusId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.DictMeetingsVotesStatusesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingVoteStatus).WithMany(p => p.DictMeetingsVotesStatusesL).HasForeignKey(d => d.MeetingVoteStatusId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictMeetingsVotesStatusesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictSettUser>(entity =>
            {
                entity.HasIndex(e => new { e.Alias }).HasName("IX_Alias").IsUnique();

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DictShedullerTasksPeriods>(entity =>
            {
                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictShedullerTasksPeriods).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictShedullerTasksPeriodsL>(entity =>
            {
                entity.HasKey(e => new { e.ShedullerTaskPeriodId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.DictShedullerTasksPeriodsL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.ShedullerTaskPeriod).WithMany(p => p.DictShedullerTasksPeriodsL).HasForeignKey(d => d.ShedullerTaskPeriodId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictShedullerTasksPeriodsL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictShedullerTasksTypes>(entity =>
            {
                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictShedullerTasksTypes).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DictShedullerTasksTypesL>(entity =>
            {
                entity.HasKey(e => new { e.ShedullerTaskTypeId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.DictShedullerTasksTypesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.ShedullerTaskType).WithMany(p => p.DictShedullerTasksTypesL).HasForeignKey(d => d.ShedullerTaskTypeId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.DictShedullerTasksTypesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Meetings>(entity =>
            {
                entity.HasIndex(e => e.ContentChangeDate).HasName("IX_ContentChangeDate");

                entity.Property(e => e.ContentChangeDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValue(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.DirectorsGroup).WithMany(p => p.Meetings).HasForeignKey(d => d.DirectorsGroupId);

                entity.HasOne(d => d.MeetingFormat).WithMany(p => p.Meetings).HasForeignKey(d => d.MeetingFormatId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingStatus).WithMany(p => p.Meetings).HasForeignKey(d => d.MeetingStatusId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.Meetings).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsAlerts>(entity =>
            {
                entity.HasIndex(e => e.CreateDate).HasName("IX_CreateDate");

                entity.HasIndex(e => e.MeetingId).HasName("IX_MeetingId");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.MeetingAlertType).WithMany(p => p.MeetingsAlerts).HasForeignKey(d => d.MeetingAlertTypeId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingsAlerts).HasForeignKey(d => d.MeetingId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsAlerts).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsAlertsL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingAlertId, e.LanguageId });

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.MeetingsAlertsL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingAlert).WithMany(p => p.MeetingsAlertsL).HasForeignKey(d => d.MeetingAlertId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsAlertsL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsAlertsUsersBrowsing>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.MeetingId });

                entity.Property(e => e.BrowseDate).HasColumnType("datetime");

                entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingsAlertsUsersBrowsing).HasForeignKey(d => d.MeetingId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.User).WithMany(p => p.MeetingsAlertsUsersBrowsing).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsDirectories>(entity =>
            {
                entity.HasIndex(e => e.ParentId).HasName("IX_ParentId");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.MeetingDirectoryType).WithMany(p => p.MeetingsDirectories).HasForeignKey(d => d.MeetingDirectoryTypeId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingsDirectories).HasForeignKey(d => d.MeetingId);

                entity.HasOne(d => d.MeetingQuestion).WithMany(p => p.MeetingsDirectories).HasForeignKey(d => d.MeetingQuestionId);

                entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsDirectories).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsDirectoriesData>(entity =>
            {
                entity.HasKey(e => new { e.MeetingDirectoryId, e.Version });

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnType("varbinary");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.MeetingDirectory).WithMany(p => p.MeetingsDirectoriesData).HasForeignKey(d => d.MeetingDirectoryId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsDirectoriesData).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsDirectoriesL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingDirectoryId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.MeetingsDirectoriesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingDirectory).WithMany(p => p.MeetingsDirectoriesL).HasForeignKey(d => d.MeetingDirectoryId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsDirectoriesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsDirsTemplates>(entity =>
            {
                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.DirectoryGroup).WithMany(p => p.MeetingsDirsTemplates).HasForeignKey(d => d.DirectoryGroupId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsDirsTemplates).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsDirsTemplatesDirectories>(entity =>
            {
                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.MeetingDirTemplate).WithMany(p => p.MeetingsDirsTemplatesDirectories).HasForeignKey(d => d.MeetingDirTemplateId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingDirectoryType).WithMany(p => p.MeetingsDirsTemplatesDirectories).HasForeignKey(d => d.MeetingDirectoryTypeId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsDirsTemplatesDirectories).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsDirsTemplatesDirectoriesL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingDirTemplateDirectoryId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.MeetingsDirsTemplatesDirectoriesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingDirTemplateDirectory).WithMany(p => p.MeetingsDirsTemplatesDirectoriesL).HasForeignKey(d => d.MeetingDirTemplateDirectoryId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsDirsTemplatesDirectoriesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.MeetingsL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingsL).HasForeignKey(d => d.MeetingId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsMembers>(entity =>
            {
                entity.HasKey(e => new { e.MeetingId, e.UserId });

                entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingsMembers).HasForeignKey(d => d.MeetingId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.User).WithMany(p => p.MeetingsMembers).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsQuestions>(entity =>
            {
                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.DirectorsGroup).WithMany(p => p.MeetingsQuestions).HasForeignKey(d => d.DirectorsGroupId);

                entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingsQuestions).HasForeignKey(d => d.MeetingId);

                entity.HasOne(d => d.ParentQuestion).WithMany(p => p.InverseParentQuestion).HasForeignKey(d => d.ParentQuestionId);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsQuestions).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsQuestionsL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingQuestionId, e.LanguageId });

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.MeetingsQuestionsL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingQuestion).WithMany(p => p.MeetingsQuestionsL).HasForeignKey(d => d.MeetingQuestionId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUsed).WithMany(p => p.MeetingsQuestionsL).HasForeignKey(d => d.UpdUsedId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsQuestionsSpeakers>(entity =>
            {
                entity.HasKey(e => new { e.MeetingQuestionId, e.UserId });

                entity.HasOne(d => d.MeetingQuestion).WithMany(p => p.MeetingsQuestionsSpeakers).HasForeignKey(d => d.MeetingQuestionId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.User).WithMany(p => p.MeetingsQuestionsSpeakers).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsVotes>(entity =>
            {
                entity.Property(e => e.CanUsersReChoice).HasDefaultValue(true);

                entity.Property(e => e.CanViewResultsBeforeEnd).HasDefaultValue(true);

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingsVotes).HasForeignKey(d => d.MeetingId);

                entity.HasOne(d => d.MeetingQuestion).WithMany(p => p.MeetingsVotes).HasForeignKey(d => d.MeetingQuestionId);

                entity.HasOne(d => d.MeetingVoteStatus).WithMany(p => p.MeetingsVotes).HasForeignKey(d => d.MeetingVoteStatusId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsVotes).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsVotesL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingVoteId, e.LanguageId });

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.MeetingsVotesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingVote).WithMany(p => p.MeetingsVotesL).HasForeignKey(d => d.MeetingVoteId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsVotesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsVotesOptions>(entity =>
            {
                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.MeetingVote).WithMany(p => p.MeetingsVotesOptions).HasForeignKey(d => d.MeetingVoteId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsVotesOptions).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsVotesOptionsL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingVoteOptionId, e.LanguageId });

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.MeetingsVotesOptionsL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingVoteOption).WithMany(p => p.MeetingsVotesOptionsL).HasForeignKey(d => d.MeetingVoteOptionId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsVotesOptionsL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsVotesTemplates>(entity =>
            {
                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsVotesTemplates).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsVotesTemplatesL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingVoteTemplateId, e.LanguageId });

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.MeetingsVotesTemplatesL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingVoteTemplate).WithMany(p => p.MeetingsVotesTemplatesL).HasForeignKey(d => d.MeetingVoteTemplateId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsVotesTemplatesL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsVotesTemplatesOptions>(entity =>
            {
                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.MeetingVoteTemplate).WithMany(p => p.MeetingsVotesTemplatesOptions).HasForeignKey(d => d.MeetingVoteTemplateId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsVotesTemplatesOptions).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsVotesTemplatesOptionsL>(entity =>
            {
                entity.HasKey(e => new { e.MeetingVoteTemplateOptionId, e.LanguageId });

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.HasOne(d => d.Language).WithMany(p => p.MeetingsVotesTemplatesOptionsL).HasForeignKey(d => d.LanguageId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.MeetingVoteTemplateOption).WithMany(p => p.MeetingsVotesTemplatesOptionsL).HasForeignKey(d => d.MeetingVoteTemplateOptionId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.UpdUser).WithMany(p => p.MeetingsVotesTemplatesOptionsL).HasForeignKey(d => d.UpdUserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<MeetingsVotesUsersChoices>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.VoteId });

                entity.HasOne(d => d.User).WithMany(p => p.MeetingsVotesUsersChoices).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Vote).WithMany(p => p.MeetingsVotesUsersChoices).HasForeignKey(d => d.VoteId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.VoteOption).WithMany(p => p.MeetingsVotesUsersChoices).HasForeignKey(d => d.VoteOptionId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SettBase>(entity =>
            {
                entity.HasKey(e => e.Alias);

                entity.Property(e => e.Alias).HasMaxLength(50);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<SettBkService>(entity =>
            {
                entity.HasKey(e => e.Alias);

                entity.Property(e => e.Alias).HasMaxLength(50);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<SettUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SettingId });

                entity.HasOne(d => d.Setting).WithMany(p => p.SettUser).HasForeignKey(d => d.SettingId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.User).WithMany(p => p.SettUser).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<StatesInternal>(entity =>
            {
                entity.HasKey(e => e.Alias);

                entity.Property(e => e.Alias).HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.AdName).HasName("IX_AdName").IsUnique();

                entity.HasIndex(e => e.Sid).HasName("IX_Sid").IsUnique();

                entity.Property(e => e.AdName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Division).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Image).HasColumnType("varbinary");

                entity.Property(e => e.IsBlocked).HasDefaultValue(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Position).HasMaxLength(200);

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UsersInDirectorsGroups>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DirectorsGroupId });

                entity.HasOne(d => d.DirectorsGroup).WithMany(p => p.UsersInDirectorsGroups).HasForeignKey(d => d.DirectorsGroupId).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.User).WithMany(p => p.UsersInDirectorsGroups).HasForeignKey(d => d.UserId).OnDelete(DeleteBehavior.Restrict);
            });

            //modelBuilder.Entity<sysdiagrams>(entity =>
            //{
            //    entity.HasKey(e => e.diagram_id);

            //    entity.Property(e => e.definition).HasColumnType("varbinary");
            //});
        }

        public virtual DbSet<BkServiceFastTasks> BkServiceFastTasks { get; set; }
        public virtual DbSet<BkServiceShedullerTasks> BkServiceShedullerTasks { get; set; }
        public virtual DbSet<DictDirectorsGroups> DictDirectorsGroups { get; set; }
        public virtual DbSet<DictDirectorsGroupsL> DictDirectorsGroupsL { get; set; }
        public virtual DbSet<DictFastTasksStatuses> DictFastTasksStatuses { get; set; }
        public virtual DbSet<DictFastTasksStatusesL> DictFastTasksStatusesL { get; set; }
        public virtual DbSet<DictFastTasksTypes> DictFastTasksTypes { get; set; }
        public virtual DbSet<DictFastTasksTypesL> DictFastTasksTypesL { get; set; }
        public virtual DbSet<DictLanguages> DictLanguages { get; set; }
        public virtual DbSet<DictMeetingsAlertsTypes> DictMeetingsAlertsTypes { get; set; }
        public virtual DbSet<DictMeetingsAlertsTypesL> DictMeetingsAlertsTypesL { get; set; }
        public virtual DbSet<DictMeetingsDirectoriesTypes> DictMeetingsDirectoriesTypes { get; set; }
        public virtual DbSet<DictMeetingsDirectoriesTypesL> DictMeetingsDirectoriesTypesL { get; set; }
        public virtual DbSet<DictMeetingsFormats> DictMeetingsFormats { get; set; }
        public virtual DbSet<DictMeetingsFormatsL> DictMeetingsFormatsL { get; set; }
        public virtual DbSet<DictMeetingsStatuses> DictMeetingsStatuses { get; set; }
        public virtual DbSet<DictMeetingsStatusesL> DictMeetingsStatusesL { get; set; }
        public virtual DbSet<DictMeetingsVotesStatuses> DictMeetingsVotesStatuses { get; set; }
        public virtual DbSet<DictMeetingsVotesStatusesL> DictMeetingsVotesStatusesL { get; set; }
        public virtual DbSet<DictSettUser> DictSettUser { get; set; }
        public virtual DbSet<DictShedullerTasksPeriods> DictShedullerTasksPeriods { get; set; }
        public virtual DbSet<DictShedullerTasksPeriodsL> DictShedullerTasksPeriodsL { get; set; }
        public virtual DbSet<DictShedullerTasksTypes> DictShedullerTasksTypes { get; set; }
        public virtual DbSet<DictShedullerTasksTypesL> DictShedullerTasksTypesL { get; set; }
        public virtual DbSet<Meetings> Meetings { get; set; }
        public virtual DbSet<MeetingsAlerts> MeetingsAlerts { get; set; }
        public virtual DbSet<MeetingsAlertsL> MeetingsAlertsL { get; set; }
        public virtual DbSet<MeetingsAlertsUsersBrowsing> MeetingsAlertsUsersBrowsing { get; set; }
        public virtual DbSet<MeetingsDirectories> MeetingsDirectories { get; set; }
        public virtual DbSet<MeetingsDirectoriesData> MeetingsDirectoriesData { get; set; }
        public virtual DbSet<MeetingsDirectoriesL> MeetingsDirectoriesL { get; set; }
        public virtual DbSet<MeetingsDirsTemplates> MeetingsDirsTemplates { get; set; }
        public virtual DbSet<MeetingsDirsTemplatesDirectories> MeetingsDirsTemplatesDirectories { get; set; }
        public virtual DbSet<MeetingsDirsTemplatesDirectoriesL> MeetingsDirsTemplatesDirectoriesL { get; set; }
        public virtual DbSet<MeetingsL> MeetingsL { get; set; }
        public virtual DbSet<MeetingsMembers> MeetingsMembers { get; set; }
        public virtual DbSet<MeetingsQuestions> MeetingsQuestions { get; set; }
        public virtual DbSet<MeetingsQuestionsL> MeetingsQuestionsL { get; set; }
        public virtual DbSet<MeetingsQuestionsSpeakers> MeetingsQuestionsSpeakers { get; set; }
        public virtual DbSet<MeetingsVotes> MeetingsVotes { get; set; }
        public virtual DbSet<MeetingsVotesL> MeetingsVotesL { get; set; }
        public virtual DbSet<MeetingsVotesOptions> MeetingsVotesOptions { get; set; }
        public virtual DbSet<MeetingsVotesOptionsL> MeetingsVotesOptionsL { get; set; }
        public virtual DbSet<MeetingsVotesTemplates> MeetingsVotesTemplates { get; set; }
        public virtual DbSet<MeetingsVotesTemplatesL> MeetingsVotesTemplatesL { get; set; }
        public virtual DbSet<MeetingsVotesTemplatesOptions> MeetingsVotesTemplatesOptions { get; set; }
        public virtual DbSet<MeetingsVotesTemplatesOptionsL> MeetingsVotesTemplatesOptionsL { get; set; }
        public virtual DbSet<MeetingsVotesUsersChoices> MeetingsVotesUsersChoices { get; set; }
        public virtual DbSet<SettBase> SettBase { get; set; }
        public virtual DbSet<SettBkService> SettBkService { get; set; }
        public virtual DbSet<SettUser> SettUser { get; set; }
        public virtual DbSet<StatesInternal> StatesInternal { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersInDirectorsGroups> UsersInDirectorsGroups { get; set; }
        //public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}