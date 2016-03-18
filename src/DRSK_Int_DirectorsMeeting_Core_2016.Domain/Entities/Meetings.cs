using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class Meetings
    {
        public Meetings()
        {
            MeetingsAlerts = new HashSet<MeetingsAlerts>();
            MeetingsAlertsUsersBrowsing = new HashSet<MeetingsAlertsUsersBrowsing>();
            MeetingsDirectories = new HashSet<MeetingsDirectories>();
            MeetingsL = new HashSet<MeetingsL>();
            MeetingsMembers = new HashSet<MeetingsMembers>();
            MeetingsQuestions = new HashSet<MeetingsQuestions>();
            MeetingsVotes = new HashSet<MeetingsVotes>();
        }

        public long Id { get; set; }
        public DateTime ContentChangeDate { get; set; }
        public DateTime Date { get; set; }
        public long? DirectorsGroupId { get; set; }
        public bool IsDeleted { get; set; }
        public long MeetingFormatId { get; set; }
        public long MeetingStatusId { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<MeetingsAlerts> MeetingsAlerts { get; set; }
        public virtual ICollection<MeetingsAlertsUsersBrowsing> MeetingsAlertsUsersBrowsing { get; set; }
        public virtual ICollection<MeetingsDirectories> MeetingsDirectories { get; set; }
        public virtual ICollection<MeetingsL> MeetingsL { get; set; }
        public virtual ICollection<MeetingsMembers> MeetingsMembers { get; set; }
        public virtual ICollection<MeetingsQuestions> MeetingsQuestions { get; set; }
        public virtual ICollection<MeetingsVotes> MeetingsVotes { get; set; }
        public virtual DictDirectorsGroups DirectorsGroup { get; set; }
        public virtual DictMeetingsFormats MeetingFormat { get; set; }
        public virtual DictMeetingsStatuses MeetingStatus { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
