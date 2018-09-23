using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timers.Shared.Repositories
{
    public interface IRepository<T>
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }

}
