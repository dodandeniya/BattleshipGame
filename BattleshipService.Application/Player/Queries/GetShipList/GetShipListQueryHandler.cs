using BattleshipService.Application.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipService.Application.Player.Queries.GetShipList
{
    public class GetshipListQueryHandler : IRequestHandler<GetShipListQuery, List<ViewShipDto>>
    {
        private readonly IGameSetup gameSetup;

        public GetshipListQueryHandler(IGameSetup gs)
        {
            gameSetup = gs;
        }

        public async Task<List<ViewShipDto>> Handle(GetShipListQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return gameSetup.State.Player1.Board.ShipList.Select(s => new ViewShipDto
            {
                ShipName = s.ShipName,
                Size = s.Size,
                ShipType = s.ShipType,
                BoardPositions = s.BoardPositions,
                LifeRemaining = s.LifeRemaining
            }).ToList();
        }
    }
}
