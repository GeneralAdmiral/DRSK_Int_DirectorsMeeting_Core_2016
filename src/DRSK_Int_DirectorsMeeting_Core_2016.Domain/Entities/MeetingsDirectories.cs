using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsDirectories
    {
        public MeetingsDirectories()
        {
            MeetingsDirectoriesData = new HashSet<MeetingsDirectoriesData>();
            MeetingsDirectoriesL = new HashSet<MeetingsDirectoriesL>();
        }

        public long Id { get; set; }
        public long MeetingDirectoryTypeId { get; set; }
        public long? MeetingId { get; set; }
        public long? MeetingQuestionId { get; set; }
        public long? ParentId { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<MeetingsDirectoriesData> MeetingsDirectoriesData { get; set; }
        public virtual ICollection<MeetingsDirectoriesL> MeetingsDirectoriesL { get; set; }
        public virtual DictMeetingsDirectoriesTypes MeetingDirectoryType { get; set; }
        public virtual Meetings Meeting { get; set; }
        public virtual MeetingsQuestions MeetingQuestion { get; set; }
        public virtual MeetingsDirectories Parent { get; set; }
        public virtual ICollection<MeetingsDirectories> InverseParent { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
