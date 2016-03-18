using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class SettUser
    {
        public long UserId { get; set; }
        public long SettingId { get; set; }
        public int? ValInt { get; set; }
        public string ValStr { get; set; }

        public virtual DictSettUser Setting { get; set; }
        public virtual Users User { get; set; }
    }
}
