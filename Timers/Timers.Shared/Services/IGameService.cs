using Timers.Shared.Models;
using Timers.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timers.Shared.Services
{
    public interface IGameService
    {
        //IEnumerable<GameVM> GetAll();
        //Game Add(Game newItem);
        GameVM GetById(Guid id);
        //void Remove(Guid id);
    }
}
