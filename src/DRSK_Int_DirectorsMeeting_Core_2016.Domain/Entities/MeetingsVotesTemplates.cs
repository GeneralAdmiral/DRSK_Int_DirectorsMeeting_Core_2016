using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsVotesTemplates
    {
        public MeetingsVotesTemplates()
        {
            MeetingsVotesTemplatesL = new HashSet<MeetingsVotesTemplatesL>();
            MeetingsVotesTemplatesOptions = new HashSet<MeetingsVotesTemplatesOptions>();
        }

        public long Id { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<MeetingsVotesTemplatesL> MeetingsVotesTemplatesL { get; set; }
        public virtual ICollection<MeetingsVotesTemplatesOptions> MeetingsVotesTemplatesOptions { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
