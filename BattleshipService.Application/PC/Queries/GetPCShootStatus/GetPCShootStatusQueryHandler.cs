using BattleshipService.Application.Enums;
using BattleshipService.Application.Interfaces;
using BattleshipService.Application.Models;
using BattleshipService.Application.utils;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipService.Application.PC.Queries.GetPCShootStatus
{
    public class GetPCShootStatusQueryHandler : IRequestHandler<GetPCShootStatusQuery, ViewPCShootStatusDto>
    {
        private readonly IGameSetup gameSetup;

        public GetPCShootStatusQueryHandler(IGameSetup gs)
        {
            gameSetup = gs;
        }

        public async Task<ViewPCShootStatusDto> Handle(GetPCShootStatusQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            ShootStatus shootStatus;
            Position position;

            do
            {
                position = RandomGenerator.GetRandomCoordinate();
                shootStatus = gameSetup.State.Player1.Board.FireShot(position);
            } while (shootStatus == ShootStatus.Invalid || shootStatus == ShootStatus.Duplicate);

            return new ViewPCShootStatusDto
            {
                ShootStatus = shootStatus,
                Position = position
            };
        }
    }
}
