using System;
using System.Collections.Generic;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Old.Abstracts;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Abstracts.Old.Questions
{
    public interface IMeetingsQuestionsRepository : IRepositoryAsync<MeetingsQuestions>, IDisposable
    {
        IEnumerable<MeetingsQuestions> MeetingsQuestions { get; }
    }
}
