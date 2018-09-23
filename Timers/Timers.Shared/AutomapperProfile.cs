using AutoMapper;
using Timers.Shared.Models;
using Timers.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timers.Shared
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Game, GameVM>();
            CreateMap<GameVM, Game>();
            CreateMap<Team, TeamVM>();
            CreateMap<TeamVM, Team>();

        }
    }
}
