using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictFastTasksStatusesL
    {
        public long FastTaskStatusId { get; set; }
        public long LanguageId { get; set; }
        public string Name { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual DictFastTasksStatuses FastTaskStatus { get; set; }
        public virtual DictLanguages Language { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
