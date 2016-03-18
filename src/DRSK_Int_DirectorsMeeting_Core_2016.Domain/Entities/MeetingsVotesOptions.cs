using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsVotesOptions
    {
        public MeetingsVotesOptions()
        {
            MeetingsVotesOptionsL = new HashSet<MeetingsVotesOptionsL>();
            MeetingsVotesUsersChoices = new HashSet<MeetingsVotesUsersChoices>();
        }

        public long Id { get; set; }
        public long MeetingVoteId { get; set; }
        public int? Order { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<MeetingsVotesOptionsL> MeetingsVotesOptionsL { get; set; }
        public virtual ICollection<MeetingsVotesUsersChoices> MeetingsVotesUsersChoices { get; set; }
        public virtual MeetingsVotes MeetingVote { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
