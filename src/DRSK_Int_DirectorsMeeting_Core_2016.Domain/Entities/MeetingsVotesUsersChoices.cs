using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsVotesUsersChoices
    {
        public long UserId { get; set; }
        public long VoteId { get; set; }
        public long VoteOptionId { get; set; }

        public virtual Users User { get; set; }
        public virtual MeetingsVotes Vote { get; set; }
        public virtual MeetingsVotesOptions VoteOption { get; set; }
    }
}
