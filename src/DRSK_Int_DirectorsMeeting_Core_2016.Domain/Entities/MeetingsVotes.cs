using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsVotes
    {
        public MeetingsVotes()
        {
            MeetingsVotesL = new HashSet<MeetingsVotesL>();
            MeetingsVotesOptions = new HashSet<MeetingsVotesOptions>();
            MeetingsVotesUsersChoices = new HashSet<MeetingsVotesUsersChoices>();
        }

        public long Id { get; set; }
        public bool CanUsersReChoice { get; set; }
        public bool CanViewResultsBeforeEnd { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? DateStart { get; set; }
        public long? MeetingId { get; set; }
        public long? MeetingQuestionId { get; set; }
        public long MeetingVoteStatusId { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<MeetingsVotesL> MeetingsVotesL { get; set; }
        public virtual ICollection<MeetingsVotesOptions> MeetingsVotesOptions { get; set; }
        public virtual ICollection<MeetingsVotesUsersChoices> MeetingsVotesUsersChoices { get; set; }
        public virtual Meetings Meeting { get; set; }
        public virtual MeetingsQuestions MeetingQuestion { get; set; }
        public virtual DictMeetingsVotesStatuses MeetingVoteStatus { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
