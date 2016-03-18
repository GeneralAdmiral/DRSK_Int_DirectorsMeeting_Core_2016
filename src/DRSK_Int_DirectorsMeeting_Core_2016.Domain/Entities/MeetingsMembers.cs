using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsMembers
    {
        public long MeetingId { get; set; }
        public long UserId { get; set; }

        public virtual Meetings Meeting { get; set; }
        public virtual Users User { get; set; }
    }
}
