using BattleshipService.Application.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipService.Application.Game.Queries.GetWinner
{
    public class GetWinnerQueryHandler : IRequestHandler<GetWinnerQuery, ViewWinnerDto>
    {
        private readonly IGameSetup gameSetup;

        public GetWinnerQueryHandler(IGameSetup gs)
        {
            gameSetup = gs;
        }


        public async Task<ViewWinnerDto> Handle(GetWinnerQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            ViewWinnerDto winner = new ViewWinnerDto { HasWinner = false, WinnerName = string.Empty };

            var p1 = gameSetup.State.Player1.Board.ShipList.All(s => s.IsSunk);
            var p2 = gameSetup.State.Player2.Board.ShipList.All(s => s.IsSunk);

            if (p1)
            {
                winner.HasWinner = true;
                winner.WinnerName = gameSetup.State.Player1.Name;
            }
            else if (p1)
            {
                winner.HasWinner = true;
                winner.WinnerName = gameSetup.State.Player2.Name;
            }

            return winner;
        }
    }
}
