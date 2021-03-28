using BattleshipService.Application.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipService.Application.Game.Queries.GetScores
{
    public class GetScoresQueryHandler : IRequestHandler<GetScoresQuery, List<ViewGetScoreDto>>
    {
        private readonly IGameSetup gameSetup;

        public GetScoresQueryHandler(IGameSetup gs)
        {
            gameSetup = gs;
        }

        public async Task<List<ViewGetScoreDto>> Handle(GetScoresQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            List<ViewGetScoreDto> list = new List<ViewGetScoreDto>();

            int p1Score = gameSetup.State.Player2.Board.ShipList.Where(s => s.IsSunk).Count();
            int p2Score = gameSetup.State.Player1.Board.ShipList.Where(s => s.IsSunk).Count();

            list.Add(new ViewGetScoreDto { PlayerName = gameSetup.State.Player1.Name, Score = p1Score });
            list.Add(new ViewGetScoreDto { PlayerName = gameSetup.State.Player2.Name, Score = p2Score });

            return list;
        }
    }
}
