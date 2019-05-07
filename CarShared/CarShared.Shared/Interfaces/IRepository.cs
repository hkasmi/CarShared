using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.Common.Interfaces
{
    public interface IRepository<T> : IDisposable
    {

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
       // IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}
