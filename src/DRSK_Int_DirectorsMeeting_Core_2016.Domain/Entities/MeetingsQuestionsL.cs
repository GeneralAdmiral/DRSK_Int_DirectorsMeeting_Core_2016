using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsQuestionsL
    {
        public long MeetingQuestionId { get; set; }
        public long LanguageId { get; set; }
        public string Decision { get; set; }
        public string Text { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUsedId { get; set; }

        public virtual DictLanguages Language { get; set; }
        public virtual MeetingsQuestions MeetingQuestion { get; set; }
        public virtual Users UpdUsed { get; set; }
    }
}
