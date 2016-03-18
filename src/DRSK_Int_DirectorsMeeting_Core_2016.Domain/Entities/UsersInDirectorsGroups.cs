using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class UsersInDirectorsGroups
    {
        public long UserId { get; set; }
        public long DirectorsGroupId { get; set; }

        public virtual DictDirectorsGroups DirectorsGroup { get; set; }
        public virtual Users User { get; set; }
    }
}
