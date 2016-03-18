using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictShedullerTasksTypes
    {
        public DictShedullerTasksTypes()
        {
            BkServiceShedullerTasks = new HashSet<BkServiceShedullerTasks>();
            DictShedullerTasksTypesL = new HashSet<DictShedullerTasksTypesL>();
        }

        public long Id { get; set; }
        public string Alias { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<BkServiceShedullerTasks> BkServiceShedullerTasks { get; set; }
        public virtual ICollection<DictShedullerTasksTypesL> DictShedullerTasksTypesL { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
