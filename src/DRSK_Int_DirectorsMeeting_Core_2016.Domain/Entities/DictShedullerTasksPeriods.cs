using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictShedullerTasksPeriods
    {
        public DictShedullerTasksPeriods()
        {
            BkServiceShedullerTasks = new HashSet<BkServiceShedullerTasks>();
            DictShedullerTasksPeriodsL = new HashSet<DictShedullerTasksPeriodsL>();
        }

        public long Id { get; set; }
        public string Formula { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<BkServiceShedullerTasks> BkServiceShedullerTasks { get; set; }
        public virtual ICollection<DictShedullerTasksPeriodsL> DictShedullerTasksPeriodsL { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
