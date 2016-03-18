using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictMeetingsDirectoriesTypes
    {
        public DictMeetingsDirectoriesTypes()
        {
            DictMeetingsDirectoriesTypesL = new HashSet<DictMeetingsDirectoriesTypesL>();
            MeetingsDirectories = new HashSet<MeetingsDirectories>();
            MeetingsDirsTemplatesDirectories = new HashSet<MeetingsDirsTemplatesDirectories>();
        }

        public long Id { get; set; }
        public string Alias { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserID { get; set; }

        public virtual ICollection<DictMeetingsDirectoriesTypesL> DictMeetingsDirectoriesTypesL { get; set; }
        public virtual ICollection<MeetingsDirectories> MeetingsDirectories { get; set; }
        public virtual ICollection<MeetingsDirsTemplatesDirectories> MeetingsDirsTemplatesDirectories { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
