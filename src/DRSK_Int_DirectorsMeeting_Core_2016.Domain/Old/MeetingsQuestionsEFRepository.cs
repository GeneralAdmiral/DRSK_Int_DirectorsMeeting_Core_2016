using System.Collections.Generic;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Entities;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Abstracts.Old.Questions;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Old.Concretes
{
    public class MeetingsQuestionsEFRepository : IMeetingsQuestionsRepository
    {
        private FosAgroContext context;
        public MeetingsQuestionsEFRepository(FosAgroContext _context)
        {
            this.context = _context;
        }
        public IEnumerable<MeetingsQuestions> MeetingsQuestions
        {
            get
            {
                return this.context.MeetingsQuestions;
            }
        }

        public async Task<MeetingsQuestions> Delete(int id)
        {
            MeetingsQuestions dbEntry = await this.context.MeetingsQuestions.FirstOrDefaultAsync(x => x.Id == id);
            if (dbEntry != null)
            {
                this.context.MeetingsQuestions.Remove(dbEntry);
                await this.context.SaveChangesAsync();
            }

            return dbEntry;
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public async void Save(MeetingsQuestions entry)
        {
            if(entry.Id == 0)
            {
                this.context.MeetingsQuestions.Add(entry);
            }
            else
            {
                MeetingsQuestions dbEntry = await this.context.MeetingsQuestions.FirstOrDefaultAsync(x => x.Id == entry.Id);
                if(dbEntry != null)
                {
                    dbEntry.DirectorsGroup = entry.DirectorsGroup;
                    dbEntry.InverseParentQuestion = entry.InverseParentQuestion;
                    dbEntry.Meeting = entry.Meeting;
                    dbEntry.MeetingsDirectories = entry.MeetingsDirectories;
                    dbEntry.MeetingsQuestionsL = entry.MeetingsQuestionsL;
                    dbEntry.MeetingsQuestionsSpeakers = entry.MeetingsQuestionsSpeakers;
                    dbEntry.MeetingsVotes = entry.MeetingsVotes;
                    dbEntry.ParentQuestion = entry.ParentQuestion;
                    dbEntry.UpdDate = entry.UpdDate;
                    dbEntry.UpdUser = entry.UpdUser;
                }
            }

            await this.context.SaveChangesAsync();
        }
    }
}
