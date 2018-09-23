using AutoMapper;
using Timers.Shared.Repositories;
using Timers.Shared.Models;
using Timers.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timers.Shared.Services
{
    public class GameService : IGameService
    {
        private readonly IMapper _mapper;

        private readonly IRepository<Game> _gameRepository;
        private readonly IRepository<GameSetting> _gameSettingRepository;
        private readonly IPlayerRepository<Player> _playerRepository;
        private readonly IRepository<Team> _teamRepository;

        public GameService(IMapper mapper, IRepository<Game> gameRepository,
            IRepository<GameSetting> gameSettingRepository,
            IPlayerRepository<Player> playerRepository,
            IRepository<Team> teamRepository)
        {
            _mapper = mapper;
            _gameRepository = gameRepository ?? throw new ArgumentNullException(nameof(gameRepository));
            _gameSettingRepository = gameSettingRepository ?? throw new ArgumentNullException(nameof(gameSettingRepository));
            _playerRepository = playerRepository ?? throw new ArgumentNullException(nameof(playerRepository));
            _teamRepository = teamRepository ?? throw new ArgumentNullException(nameof(teamRepository));
        }

        public GameVM GetById(Guid id)
        {
            var game = _gameRepository.GetById(id);
            var gameVM = _mapper.Map<Game, GameVM>(game);

            var homeTeam = _teamRepository.GetById(gameVM.HomeTeamId);
            var homeTeamVM = _mapper.Map<Team, TeamVM>(homeTeam);
            homeTeamVM.Players = _playerRepository.GetItemsById(gameVM.HomeTeamId).ToList();
            gameVM.HomeTeam = homeTeamVM;

            var visitorTeam = _teamRepository.GetById(gameVM.VisitorTeamId);
            var visitorTeamVM = _mapper.Map<Team, TeamVM>(visitorTeam);
            visitorTeamVM.Players = _playerRepository.GetItemsById(gameVM.VisitorTeamId).ToList();
            gameVM.VisitorTeam = visitorTeamVM;

            gameVM.GameSetting = _gameSettingRepository.GetById(gameVM.GameSettingId);

            return gameVM;
        }

    }
}
