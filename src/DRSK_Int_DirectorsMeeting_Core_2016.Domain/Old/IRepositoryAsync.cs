using System.Threading.Tasks;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Old.Abstracts
{
    public interface IRepositoryAsync<T>
    {
        void Save(T entry);

        Task<T> Delete(int entryId);
    }
}
