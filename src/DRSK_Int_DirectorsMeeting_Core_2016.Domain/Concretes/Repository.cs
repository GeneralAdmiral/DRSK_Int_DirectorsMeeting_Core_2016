using DRSK_Int_DirectorsMeeting_Core_2016.Domain.Abstracts;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Data.Entity.ChangeTracking;

namespace DRSK_Int_DirectorsMeeting_Core_2016.Domain.Concretes
{
    public class Repository<T> : IDisposable, IRepository<T> where T : class, IEntity //IDisposable,
    {
        private readonly FosAgroContext _dbContext;

        public Repository(FosAgroContext dbContext)
        {
            this._dbContext = dbContext;
        }

        #region IRepository own methods

        public virtual EntityEntry<T> Entry<T>(T entity) where T : class
        {
            return this._dbContext.Entry<T>(entity);
        }

        public virtual Task<T> GetAsync(long entryId)
        {
            return this._dbContext.Set<T>().SingleOrDefaultAsync(x => x.Id == entryId);
        }

        public virtual Task<T> GetAsync(Expression<Func<T, bool>> predicat)
        {
            return this._dbContext.Set<T>().FirstOrDefaultAsync(predicat);
        }

        public virtual T Get(long entryId)
        {
            return this._dbContext.Set<T>().FirstOrDefault(x => x.Id == entryId);
        }

        public virtual async Task<int> AddAsync(T entry)
        {
            if (entry.Id == 0)
            {
                this._dbContext.Set<T>().Add(entry);
            }

            return await this._dbContext.SaveChangesAsync();
        }

        public virtual int Add(T entry)
        {
            if (entry.Id == 0)
            {
                this._dbContext.Set<T>().Add(entry);
            }

            return this._dbContext.SaveChanges();
        }

        public virtual async Task<IEnumerable<T>> ListAsync()
        {
            return await this._dbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> predicat)
        {
            // To use the Where() method need to add  "System.Runtime": "" or "dnx451": { },
            return await _dbContext.Set<T>().Where(predicat).ToListAsync();
        }

        public virtual IEnumerable<T> List()
        {
            return this._dbContext.Set<T>().ToList();
        }

        public virtual IEnumerable<T> List(Expression<Func<T, bool>> predicat)
        {
            // To use the Where() method need to add  "System.Runtime": "" or "dnx451": { },
            return _dbContext.Set<T>().Where(predicat).ToList();
        }

        public virtual async Task<int> UpdateAsync(T entry)
        {
            if (entry.Id >= 0)
            {
                this._dbContext.Set<T>().Update(entry);
            }

            return await this._dbContext.SaveChangesAsync();
        }

        public virtual int Update(T entry)
        {
            if (entry.Id >= 0)
            {
                this._dbContext.Set<T>().Update(entry);
            }

            return this._dbContext.SaveChanges();
        }

        public virtual async Task<int> DeleteAsync(T entry)
        {
            this._dbContext.Set<T>().Remove(entry);
            return await this._dbContext.SaveChangesAsync();
        }

        public virtual int Delete(T entry)
        {
            this._dbContext.Set<T>().Remove(entry);

            return this._dbContext.SaveChanges();
        }

        public virtual Task<int> SaveChangesAsync()
        {
            return this._dbContext.SaveChangesAsync();
        }

        #endregion

        #region Implementation

        public Expression Expression
        {
            get
            {
                return this._dbContext.Set<T>().AsQueryable().Expression;
            }
        }

        public Type ElementType
        {
            get
            {
                return this._dbContext.Set<T>().AsQueryable().ElementType;
            }
        }

        public IQueryProvider Provider
        {
            get
            {
                return this._dbContext.Set<T>().AsQueryable().Provider;
            }
        }

        public void Dispose()
        {
            this._dbContext.Dispose();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this._dbContext.Set<T>().ToList().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._dbContext.Set<T>().ToList().GetEnumerator();
        }
        #endregion
    }
}
