using Microsoft.Extensions.DependencyInjection;
using Timers.Shared.Services;
using Timers.Shared.ViewModels;
using System;
using Xunit;

namespace Timers.Tests
{
    [Collection("DI collection")]
    public class GameServiceTests
    {
        private readonly IGameService _gameService;
        public GameVM _gameVM { get; private set; }


        public GameServiceTests(FixtureDI fixture)
        {
            var serviceProvider = fixture.ServiceProvider;
            _gameService = serviceProvider.GetService<IGameService>();
            _gameVM = _gameService.GetById(new Guid("d66945ca-e9ef-4b5b-8084-35ea568d937c"));
        }

        [Fact]
        public void HomeTeamName_ShouldBe_Galaxy()
        {
            var homeTeamName = _gameVM.HomeTeam.Name;

            Assert.Equal("Galaxy", homeTeamName);
        }

        [Fact]
        public void VisitorTeamName_ShouldBe_DCUnited()
        {
            var visitorTeamName = _gameVM.VisitorTeam.Name;

            Assert.Equal("DC United", visitorTeamName);
        }

        [Fact]
        public void GameSettingName_ShouldBe_IndoorSoccer()
        {
            var gameSettingName = _gameVM.GameSetting.Name;

            Assert.Equal("Indoor Soccer", gameSettingName);
        }

    }

}

