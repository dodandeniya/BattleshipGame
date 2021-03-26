using BattleshipService.Application.Common;
using BattleshipService.Application.Interfaces;
using BattleshipService.Application.Models;
using BattleshipService.Application.Ships.Enums;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipService.Application.Ships.Commands.PlaceShip
{
    public class PlaceShipCommandHandler : IRequestHandler<PlaceShipCommand, ShipPlacement>
    {
        private readonly IBoardDimension boardDimension;

        public PlaceShipCommandHandler(IBoardDimension boardDimension)
        {
            this.boardDimension = boardDimension;
        }

        public async Task<ShipPlacement> Handle(PlaceShipCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (!IsPositionWithingBoard(request.Coordinate))
                return ShipPlacement.OutOfBoundary;

            IShip newShip = ShipFactory.CreateShip(request.ShipType);
            newShip.BoardPositions.a

        }

        private bool IsPositionWithingBoard(Position position)
        {
            return position.XPosition >= 1 && position.XPosition <= boardDimension.Width &&
           position.YPosition >= 1 && position.YPosition <= boardDimension.Height;
        }
    }
}
