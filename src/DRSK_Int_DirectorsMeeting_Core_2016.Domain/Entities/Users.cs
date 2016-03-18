using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Abstracts;
using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class Users : IEntity
    {
        public Users()
        {
            BkServiceShedullerTasks = new HashSet<BkServiceShedullerTasks>();
            DictDirectorsGroups = new HashSet<DictDirectorsGroups>();
            DictDirectorsGroupsL = new HashSet<DictDirectorsGroupsL>();
            DictFastTasksStatuses = new HashSet<DictFastTasksStatuses>();
            DictFastTasksStatusesL = new HashSet<DictFastTasksStatusesL>();
            DictFastTasksTypes = new HashSet<DictFastTasksTypes>();
            DictFastTasksTypesL = new HashSet<DictFastTasksTypesL>();
            DictLanguages = new HashSet<DictLanguages>();
            DictMeetingsAlertsTypes = new HashSet<DictMeetingsAlertsTypes>();
            DictMeetingsAlertsTypesL = new HashSet<DictMeetingsAlertsTypesL>();
            DictMeetingsDirectoriesTypes = new HashSet<DictMeetingsDirectoriesTypes>();
            DictMeetingsDirectoriesTypesL = new HashSet<DictMeetingsDirectoriesTypesL>();
            DictMeetingsFormats = new HashSet<DictMeetingsFormats>();
            DictMeetingsFormatsL = new HashSet<DictMeetingsFormatsL>();
            DictMeetingsStatuses = new HashSet<DictMeetingsStatuses>();
            DictMeetingsStatusesL = new HashSet<DictMeetingsStatusesL>();
            DictMeetingsVotesStatuses = new HashSet<DictMeetingsVotesStatuses>();
            DictMeetingsVotesStatusesL = new HashSet<DictMeetingsVotesStatusesL>();
            DictShedullerTasksPeriods = new HashSet<DictShedullerTasksPeriods>();
            DictShedullerTasksPeriodsL = new HashSet<DictShedullerTasksPeriodsL>();
            DictShedullerTasksTypes = new HashSet<DictShedullerTasksTypes>();
            DictShedullerTasksTypesL = new HashSet<DictShedullerTasksTypesL>();
            Meetings = new HashSet<Meetings>();
            MeetingsAlerts = new HashSet<MeetingsAlerts>();
            MeetingsAlertsL = new HashSet<MeetingsAlertsL>();
            MeetingsAlertsUsersBrowsing = new HashSet<MeetingsAlertsUsersBrowsing>();
            MeetingsDirectories = new HashSet<MeetingsDirectories>();
            MeetingsDirectoriesData = new HashSet<MeetingsDirectoriesData>();
            MeetingsDirectoriesL = new HashSet<MeetingsDirectoriesL>();
            MeetingsDirsTemplates = new HashSet<MeetingsDirsTemplates>();
            MeetingsDirsTemplatesDirectories = new HashSet<MeetingsDirsTemplatesDirectories>();
            MeetingsDirsTemplatesDirectoriesL = new HashSet<MeetingsDirsTemplatesDirectoriesL>();
            MeetingsMembers = new HashSet<MeetingsMembers>();
            MeetingsQuestions = new HashSet<MeetingsQuestions>();
            MeetingsQuestionsL = new HashSet<MeetingsQuestionsL>();
            MeetingsQuestionsSpeakers = new HashSet<MeetingsQuestionsSpeakers>();
            MeetingsVotes = new HashSet<MeetingsVotes>();
            MeetingsVotesL = new HashSet<MeetingsVotesL>();
            MeetingsVotesOptions = new HashSet<MeetingsVotesOptions>();
            MeetingsVotesOptionsL = new HashSet<MeetingsVotesOptionsL>();
            MeetingsVotesTemplates = new HashSet<MeetingsVotesTemplates>();
            MeetingsVotesTemplatesL = new HashSet<MeetingsVotesTemplatesL>();
            MeetingsVotesTemplatesOptions = new HashSet<MeetingsVotesTemplatesOptions>();
            MeetingsVotesTemplatesOptionsL = new HashSet<MeetingsVotesTemplatesOptionsL>();
            MeetingsVotesUsersChoices = new HashSet<MeetingsVotesUsersChoices>();
            SettUser = new HashSet<SettUser>();
            UsersInDirectorsGroups = new HashSet<UsersInDirectorsGroups>();
        }

        public long Id { get; set; }
        public string AdName { get; set; }
        public string Division { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public bool IsBlocked { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Sid { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual ICollection<BkServiceShedullerTasks> BkServiceShedullerTasks { get; set; }
        public virtual ICollection<DictDirectorsGroups> DictDirectorsGroups { get; set; }
        public virtual ICollection<DictDirectorsGroupsL> DictDirectorsGroupsL { get; set; }
        public virtual ICollection<DictFastTasksStatuses> DictFastTasksStatuses { get; set; }
        public virtual ICollection<DictFastTasksStatusesL> DictFastTasksStatusesL { get; set; }
        public virtual ICollection<DictFastTasksTypes> DictFastTasksTypes { get; set; }
        public virtual ICollection<DictFastTasksTypesL> DictFastTasksTypesL { get; set; }
        public virtual ICollection<DictLanguages> DictLanguages { get; set; }
        public virtual ICollection<DictMeetingsAlertsTypes> DictMeetingsAlertsTypes { get; set; }
        public virtual ICollection<DictMeetingsAlertsTypesL> DictMeetingsAlertsTypesL { get; set; }
        public virtual ICollection<DictMeetingsDirectoriesTypes> DictMeetingsDirectoriesTypes { get; set; }
        public virtual ICollection<DictMeetingsDirectoriesTypesL> DictMeetingsDirectoriesTypesL { get; set; }
        public virtual ICollection<DictMeetingsFormats> DictMeetingsFormats { get; set; }
        public virtual ICollection<DictMeetingsFormatsL> DictMeetingsFormatsL { get; set; }
        public virtual ICollection<DictMeetingsStatuses> DictMeetingsStatuses { get; set; }
        public virtual ICollection<DictMeetingsStatusesL> DictMeetingsStatusesL { get; set; }
        public virtual ICollection<DictMeetingsVotesStatuses> DictMeetingsVotesStatuses { get; set; }
        public virtual ICollection<DictMeetingsVotesStatusesL> DictMeetingsVotesStatusesL { get; set; }
        public virtual ICollection<DictShedullerTasksPeriods> DictShedullerTasksPeriods { get; set; }
        public virtual ICollection<DictShedullerTasksPeriodsL> DictShedullerTasksPeriodsL { get; set; }
        public virtual ICollection<DictShedullerTasksTypes> DictShedullerTasksTypes { get; set; }
        public virtual ICollection<DictShedullerTasksTypesL> DictShedullerTasksTypesL { get; set; }
        public virtual ICollection<Meetings> Meetings { get; set; }
        public virtual ICollection<MeetingsAlerts> MeetingsAlerts { get; set; }
        public virtual ICollection<MeetingsAlertsL> MeetingsAlertsL { get; set; }
        public virtual ICollection<MeetingsAlertsUsersBrowsing> MeetingsAlertsUsersBrowsing { get; set; }
        public virtual ICollection<MeetingsDirectories> MeetingsDirectories { get; set; }
        public virtual ICollection<MeetingsDirectoriesData> MeetingsDirectoriesData { get; set; }
        public virtual ICollection<MeetingsDirectoriesL> MeetingsDirectoriesL { get; set; }
        public virtual ICollection<MeetingsDirsTemplates> MeetingsDirsTemplates { get; set; }
        public virtual ICollection<MeetingsDirsTemplatesDirectories> MeetingsDirsTemplatesDirectories { get; set; }
        public virtual ICollection<MeetingsDirsTemplatesDirectoriesL> MeetingsDirsTemplatesDirectoriesL { get; set; }
        public virtual ICollection<MeetingsMembers> MeetingsMembers { get; set; }
        public virtual ICollection<MeetingsQuestions> MeetingsQuestions { get; set; }
        public virtual ICollection<MeetingsQuestionsL> MeetingsQuestionsL { get; set; }
        public virtual ICollection<MeetingsQuestionsSpeakers> MeetingsQuestionsSpeakers { get; set; }
        public virtual ICollection<MeetingsVotes> MeetingsVotes { get; set; }
        public virtual ICollection<MeetingsVotesL> MeetingsVotesL { get; set; }
        public virtual ICollection<MeetingsVotesOptions> MeetingsVotesOptions { get; set; }
        public virtual ICollection<MeetingsVotesOptionsL> MeetingsVotesOptionsL { get; set; }
        public virtual ICollection<MeetingsVotesTemplates> MeetingsVotesTemplates { get; set; }
        public virtual ICollection<MeetingsVotesTemplatesL> MeetingsVotesTemplatesL { get; set; }
        public virtual ICollection<MeetingsVotesTemplatesOptions> MeetingsVotesTemplatesOptions { get; set; }
        public virtual ICollection<MeetingsVotesTemplatesOptionsL> MeetingsVotesTemplatesOptionsL { get; set; }
        public virtual ICollection<MeetingsVotesUsersChoices> MeetingsVotesUsersChoices { get; set; }
        public virtual ICollection<SettUser> SettUser { get; set; }
        public virtual ICollection<UsersInDirectorsGroups> UsersInDirectorsGroups { get; set; }
    }
}
