using BattleshipService.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipService.Application.Player.Queries.GetShootStatus
{
    public class GetShootStatusQueryHandler : IRequestHandler<GetShootStatusQuery, ViewShootStatusDto>
    {
        private readonly IGameSetup gameSetup;

        public GetShootStatusQueryHandler(IGameSetup gs)
        {
            gameSetup = gs;
        }

        public async Task<ViewShootStatusDto> Handle(GetShootStatusQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return new ViewShootStatusDto
            {
                ShootStatus = gameSetup.State.Player2.Board.FireShot(request.Position),
                Position = request.Position
            };
        }
    }
}
