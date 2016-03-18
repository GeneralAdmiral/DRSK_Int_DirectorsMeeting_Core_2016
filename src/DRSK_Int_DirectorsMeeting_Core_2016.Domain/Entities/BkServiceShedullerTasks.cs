using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class BkServiceShedullerTasks
    {
        public long Id { get; set; }
        public string Comment { get; set; }
        public DateTime? LastExecDate { get; set; }
        public DateTime? LastExecEndDate { get; set; }
        public string Name { get; set; }
        public DateTime? NextExecDate { get; set; }
        public long? RefObjId { get; set; }
        public long? ShedullerTaskPeriodId { get; set; }
        public long ShedullerTaskTypeId { get; set; }
        public DateTime StartExecDate { get; set; }
        public string TaskData { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual DictShedullerTasksPeriods ShedullerTaskPeriod { get; set; }
        public virtual DictShedullerTasksTypes ShedullerTaskType { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
