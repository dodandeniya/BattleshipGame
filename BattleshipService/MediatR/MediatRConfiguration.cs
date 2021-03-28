using Microsoft.Extensions.DependencyInjection;
using MediatR;
using BattleshipService.Application.Player.Commands.CreatePlayer;
using BattleshipService.Application.Player.Queries.GetPlayers;
using BattleshipService.Application.Player.Queries.GetShipList;

namespace BattleshipService.MediatR
{
    public static class MediatRConfiguration
    {
        public static void AddMediatRConfiguration(this IServiceCollection services)
        {
            services.AddMediatR(
                typeof(CreatePlayerCommandHandler),
                typeof(GetPlayersQueryHandler),
                typeof(GetshipListQueryHandler)
            );
        }
    }
}
