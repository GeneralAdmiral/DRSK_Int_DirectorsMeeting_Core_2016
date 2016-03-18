using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Abstracts;
using System;
using System.Collections.Generic;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities
{
    public partial class MeetingsQuestions : IEntity
    {
        public MeetingsQuestions()
        {
            MeetingsDirectories = new HashSet<MeetingsDirectories>();
            MeetingsQuestionsL = new HashSet<MeetingsQuestionsL>();
            MeetingsQuestionsSpeakers = new HashSet<MeetingsQuestionsSpeakers>();
            MeetingsVotes = new HashSet<MeetingsVotes>();
        }

        public long Id { get; set; }
        public long? DirectorsGroupId { get; set; }
        public long? MeetingId { get; set; }
        public long? ParentQuestionId { get; set; }
        public DateTime UpdDate { get; set; }
        public long UpdUserId { get; set; }

        public virtual ICollection<MeetingsDirectories> MeetingsDirectories { get; set; }
        public virtual ICollection<MeetingsQuestionsL> MeetingsQuestionsL { get; set; }
        public virtual ICollection<MeetingsQuestionsSpeakers> MeetingsQuestionsSpeakers { get; set; }
        public virtual ICollection<MeetingsVotes> MeetingsVotes { get; set; }
        public virtual DictDirectorsGroups DirectorsGroup { get; set; }
        public virtual Meetings Meeting { get; set; }
        public virtual MeetingsQuestions ParentQuestion { get; set; }
        public virtual ICollection<MeetingsQuestions> InverseParentQuestion { get; set; }
        public virtual Users UpdUser { get; set; }
    }
}
