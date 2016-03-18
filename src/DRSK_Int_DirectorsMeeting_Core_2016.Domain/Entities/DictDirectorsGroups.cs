using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictDirectorsGroups
    {
        public DictDirectorsGroups()
        {
            DictDirectorsGroupsL = new HashSet<DictDirectorsGroupsL>();
            Meetings = new HashSet<Meetings>();
            MeetingsDirsTemplates = new HashSet<MeetingsDirsTemplates>();
            MeetingsQuestions = new HashSet<MeetingsQuestions>();
            UsersInDirectorsGroups = new HashSet<UsersInDirectorsGroups>();
        }

        public long Id { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<DictDirectorsGroupsL> DictDirectorsGroupsL { get; set; }
        public virtual ICollection<Meetings> Meetings { get; set; }
        public virtual ICollection<MeetingsDirsTemplates> MeetingsDirsTemplates { get; set; }
        public virtual ICollection<MeetingsQuestions> MeetingsQuestions { get; set; }
        public virtual ICollection<UsersInDirectorsGroups> UsersInDirectorsGroups { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
