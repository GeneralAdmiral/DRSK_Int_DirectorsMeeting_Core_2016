using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsQuestionsSpeakers
    {
        public long MeetingQuestionId { get; set; }
        public long UserId { get; set; }

        public virtual MeetingsQuestions MeetingQuestion { get; set; }
        public virtual Users User { get; set; }
    }
}
