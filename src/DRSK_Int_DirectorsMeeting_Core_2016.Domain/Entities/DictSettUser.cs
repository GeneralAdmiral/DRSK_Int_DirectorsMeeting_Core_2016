using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class DictSettUser
    {
        public DictSettUser()
        {
            SettUser = new HashSet<SettUser>();
        }

        public long Id { get; set; }
        public string Alias { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<SettUser> SettUser { get; set; }
    }
}
