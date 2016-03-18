using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsDirsTemplates
    {
        public MeetingsDirsTemplates()
        {
            MeetingsDirsTemplatesDirectories = new HashSet<MeetingsDirsTemplatesDirectories>();
        }

        public long Id { get; set; }
        public long DirectoryGroupId { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<MeetingsDirsTemplatesDirectories> MeetingsDirsTemplatesDirectories { get; set; }
        public virtual DictDirectorsGroups DirectoryGroup { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
