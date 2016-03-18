using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsDirsTemplatesDirectories
    {
        public MeetingsDirsTemplatesDirectories()
        {
            MeetingsDirsTemplatesDirectoriesL = new HashSet<MeetingsDirsTemplatesDirectoriesL>();
        }

        public long Id { get; set; }
        public long MeetingDirectoryTypeId { get; set; }
        public long MeetingDirTemplateId { get; set; }
        public long? ParentId { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<MeetingsDirsTemplatesDirectoriesL> MeetingsDirsTemplatesDirectoriesL { get; set; }
        public virtual MeetingsDirsTemplates MeetingDirTemplate { get; set; }
        public virtual DictMeetingsDirectoriesTypes MeetingDirectoryType { get; set; }
        public virtual MeetingsDirsTemplatesDirectories Parent { get; set; }
        public virtual ICollection<MeetingsDirsTemplatesDirectories> InverseParent { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
