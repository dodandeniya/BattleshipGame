using BattleshipService.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipService.Application.Player.Queries.GetShootStatus
{
    public class GetShootStatusQueryHandler : IRequestHandler<GetShootStatusQuery, ViewShootStatusQueryDto>
    {
        private readonly IGameSetup gameSetup;

        public GetShootStatusQueryHandler(IGameSetup gs)
        {
            gameSetup = gs;
        }

        public async Task<ViewShootStatusQueryDto> Handle(GetShootStatusQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var pos = request.Position;

            return new ViewShootStatusQueryDto
            {
                ShootStatus = gameSetup.State.Player2.Board.FireShot(request.Position),
                Position = request.Position
            };
        }
    }
}
