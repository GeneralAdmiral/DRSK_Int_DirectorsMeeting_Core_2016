using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictLanguages
    {
        public DictLanguages()
        {
            DictDirectorsGroupsL = new HashSet<DictDirectorsGroupsL>();
            DictFastTasksStatusesL = new HashSet<DictFastTasksStatusesL>();
            DictFastTasksTypesL = new HashSet<DictFastTasksTypesL>();
            DictMeetingsAlertsTypesL = new HashSet<DictMeetingsAlertsTypesL>();
            DictMeetingsDirectoriesTypesL = new HashSet<DictMeetingsDirectoriesTypesL>();
            DictMeetingsFormatsL = new HashSet<DictMeetingsFormatsL>();
            DictMeetingsStatusesL = new HashSet<DictMeetingsStatusesL>();
            DictMeetingsVotesStatusesL = new HashSet<DictMeetingsVotesStatusesL>();
            DictShedullerTasksPeriodsL = new HashSet<DictShedullerTasksPeriodsL>();
            DictShedullerTasksTypesL = new HashSet<DictShedullerTasksTypesL>();
            MeetingsAlertsL = new HashSet<MeetingsAlertsL>();
            MeetingsDirectoriesL = new HashSet<MeetingsDirectoriesL>();
            MeetingsDirsTemplatesDirectoriesL = new HashSet<MeetingsDirsTemplatesDirectoriesL>();
            MeetingsL = new HashSet<MeetingsL>();
            MeetingsQuestionsL = new HashSet<MeetingsQuestionsL>();
            MeetingsVotesL = new HashSet<MeetingsVotesL>();
            MeetingsVotesOptionsL = new HashSet<MeetingsVotesOptionsL>();
            MeetingsVotesTemplatesL = new HashSet<MeetingsVotesTemplatesL>();
            MeetingsVotesTemplatesOptionsL = new HashSet<MeetingsVotesTemplatesOptionsL>();
        }

        public long Id { get; set; }
        public string Alias { get; set; }
        public bool IsDefault { get; set; }
        public string Name { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<DictDirectorsGroupsL> DictDirectorsGroupsL { get; set; }
        public virtual ICollection<DictFastTasksStatusesL> DictFastTasksStatusesL { get; set; }
        public virtual ICollection<DictFastTasksTypesL> DictFastTasksTypesL { get; set; }
        public virtual ICollection<DictMeetingsAlertsTypesL> DictMeetingsAlertsTypesL { get; set; }
        public virtual ICollection<DictMeetingsDirectoriesTypesL> DictMeetingsDirectoriesTypesL { get; set; }
        public virtual ICollection<DictMeetingsFormatsL> DictMeetingsFormatsL { get; set; }
        public virtual ICollection<DictMeetingsStatusesL> DictMeetingsStatusesL { get; set; }
        public virtual ICollection<DictMeetingsVotesStatusesL> DictMeetingsVotesStatusesL { get; set; }
        public virtual ICollection<DictShedullerTasksPeriodsL> DictShedullerTasksPeriodsL { get; set; }
        public virtual ICollection<DictShedullerTasksTypesL> DictShedullerTasksTypesL { get; set; }
        public virtual ICollection<MeetingsAlertsL> MeetingsAlertsL { get; set; }
        public virtual ICollection<MeetingsDirectoriesL> MeetingsDirectoriesL { get; set; }
        public virtual ICollection<MeetingsDirsTemplatesDirectoriesL> MeetingsDirsTemplatesDirectoriesL { get; set; }
        public virtual ICollection<MeetingsL> MeetingsL { get; set; }
        public virtual ICollection<MeetingsQuestionsL> MeetingsQuestionsL { get; set; }
        public virtual ICollection<MeetingsVotesL> MeetingsVotesL { get; set; }
        public virtual ICollection<MeetingsVotesOptionsL> MeetingsVotesOptionsL { get; set; }
        public virtual ICollection<MeetingsVotesTemplatesL> MeetingsVotesTemplatesL { get; set; }
        public virtual ICollection<MeetingsVotesTemplatesOptionsL> MeetingsVotesTemplatesOptionsL { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
