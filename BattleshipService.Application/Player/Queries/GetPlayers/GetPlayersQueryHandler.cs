using BattleshipService.Application.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipService.Application.Player.Queries.GetPlayers
{
    public class GetPlayersQueryHandler : IRequestHandler<GetPlayersQuery, List<ViewPlayerDto>>
    {
        private readonly IGameSetup gameSetup;

        public GetPlayersQueryHandler(IGameSetup gs)
        {
            gameSetup = gs;
        }

        public async Task<List<ViewPlayerDto>> Handle(GetPlayersQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var p1 = gameSetup.State.Player1;
            var p2 = gameSetup.State.Player2;

            List<ViewPlayerDto> list = new List<ViewPlayerDto>() { new ViewPlayerDto() { Name = p1.Name, IsHuman = p1.IsHuman }, new ViewPlayerDto() { Name = p2.Name, IsHuman = p2.IsHuman } };

            return list;
        }
    }
}
