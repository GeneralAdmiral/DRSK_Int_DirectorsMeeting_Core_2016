using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictMeetingsAlertsTypes
    {
        public DictMeetingsAlertsTypes()
        {
            DictMeetingsAlertsTypesL = new HashSet<DictMeetingsAlertsTypesL>();
            MeetingsAlerts = new HashSet<MeetingsAlerts>();
        }

        public long Id { get; set; }
        public string Alias { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<DictMeetingsAlertsTypesL> DictMeetingsAlertsTypesL { get; set; }
        public virtual ICollection<MeetingsAlerts> MeetingsAlerts { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
