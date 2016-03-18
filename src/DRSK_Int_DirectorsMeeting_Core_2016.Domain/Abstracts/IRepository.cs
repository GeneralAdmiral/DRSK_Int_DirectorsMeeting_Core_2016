using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Abstracts
{
    public interface IRepository<TEntity> : IDisposable, IQueryable<TEntity>, IEnumerable<TEntity> where TEntity : IEntity
    {
        Task<TEntity> GetAsync(long entryId);

        TEntity Get(long entryId);

        Task<IEnumerable<TEntity>> ListAsync();

        IEnumerable<TEntity> List();

        Task<IEnumerable<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicat);

        IEnumerable<TEntity> List(Expression<Func<TEntity, bool>> predicat);

        Task<int> AddAsync(TEntity entry);

        int Add(TEntity entry);

        int Update(TEntity entry);

        Task<int> UpdateAsync(TEntity entry);

        int Delete(TEntity entry);

        Task<int> DeleteAsync(TEntity entry);
    }
}
