using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsVotesTemplatesOptions
    {
        public MeetingsVotesTemplatesOptions()
        {
            MeetingsVotesTemplatesOptionsL = new HashSet<MeetingsVotesTemplatesOptionsL>();
        }

        public long Id { get; set; }
        public long MeetingVoteTemplateId { get; set; }
        public int? Order { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<MeetingsVotesTemplatesOptionsL> MeetingsVotesTemplatesOptionsL { get; set; }
        public virtual MeetingsVotesTemplates MeetingVoteTemplate { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
