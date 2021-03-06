using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictMeetingsVotesStatuses
    {
        public DictMeetingsVotesStatuses()
        {
            DictMeetingsVotesStatusesL = new HashSet<DictMeetingsVotesStatusesL>();
            MeetingsVotes = new HashSet<MeetingsVotes>();
        }

        public long Id { get; set; }
        public string Alias { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<DictMeetingsVotesStatusesL> DictMeetingsVotesStatusesL { get; set; }
        public virtual ICollection<MeetingsVotes> MeetingsVotes { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
