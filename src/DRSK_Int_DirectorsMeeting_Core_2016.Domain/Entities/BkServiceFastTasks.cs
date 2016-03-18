using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class BkServiceFastTasks
    {
        public long Id { get; set; }
        public long FastTaskStatusId { get; set; }
        public long FastTaskTypeId { get; set; }
        public string Name { get; set; }
        public string NotifyEmails { get; set; }
        public DateTime RegisterDate { get; set; }
        public string StatusComment { get; set; }
        public DateTime StatusDate { get; set; }
        public string TaskData { get; set; }
        public long UserId { get; set; }

        public virtual DictFastTasksStatuses FastTaskStatus { get; set; }
        public virtual DictFastTasksTypes FastTaskType { get; set; }
    }
}
