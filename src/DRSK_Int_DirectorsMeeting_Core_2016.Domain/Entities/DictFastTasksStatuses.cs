using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictFastTasksStatuses
    {
        public DictFastTasksStatuses()
        {
            BkServiceFastTasks = new HashSet<BkServiceFastTasks>();
            DictFastTasksStatusesL = new HashSet<DictFastTasksStatusesL>();
        }

        public long Id { get; set; }
        public string Alias { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<BkServiceFastTasks> BkServiceFastTasks { get; set; }
        public virtual ICollection<DictFastTasksStatusesL> DictFastTasksStatusesL { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
