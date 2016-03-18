using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictMeetingsFormats
    {
        public DictMeetingsFormats()
        {
            DictMeetingsFormatsL = new HashSet<DictMeetingsFormatsL>();
            Meetings = new HashSet<Meetings>();
        }

        public long Id { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<DictMeetingsFormatsL> DictMeetingsFormatsL { get; set; }
        public virtual ICollection<Meetings> Meetings { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
