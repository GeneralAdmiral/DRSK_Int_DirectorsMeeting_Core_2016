using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsDirectoriesData
    {
        public long MeetingDirectoryId { get; set; }
        public int Version { get; set; }
        public byte[] Data { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual MeetingsDirectories MeetingDirectory { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
