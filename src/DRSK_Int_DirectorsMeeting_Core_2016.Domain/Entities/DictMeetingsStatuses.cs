using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictMeetingsStatuses
    {
        public DictMeetingsStatuses()
        {
            DictMeetingsStatusesL = new HashSet<DictMeetingsStatusesL>();
            Meetings = new HashSet<Meetings>();
        }

        public long Id { get; set; }
        public string Alias { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<DictMeetingsStatusesL> DictMeetingsStatusesL { get; set; }
        public virtual ICollection<Meetings> Meetings { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
