using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsAlerts
    {
        public MeetingsAlerts()
        {
            MeetingsAlertsL = new HashSet<MeetingsAlertsL>();
        }

        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public long MeetingAlertTypeId { get; set; }
        public long MeetingId { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<MeetingsAlertsL> MeetingsAlertsL { get; set; }
        public virtual DictMeetingsAlertsTypes MeetingAlertType { get; set; }
        public virtual Meetings Meeting { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
