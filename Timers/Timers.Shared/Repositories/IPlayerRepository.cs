using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timers.Shared.Repositories
{
    public interface IPlayerRepository<T> : IRepository<T>
    {
        IEnumerable<T> GetItemsById(Guid teamId);
    }
}
