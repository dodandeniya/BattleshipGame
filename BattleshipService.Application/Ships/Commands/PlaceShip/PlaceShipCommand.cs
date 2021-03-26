using BattleshipService.Application.Enums;
using BattleshipService.Application.Models;
using BattleshipService.Application.Ships.Enums;
using MediatR;

namespace BattleshipService.Application.Ships.Commands.PlaceShip
{
    public class PlaceShipCommand : IRequest<ShipPlacement>
    {
        public Position Coordinate { get; set; }
        public ShipDirection Direction { get; set; }
        public ShipType ShipType { get; set; }
    }
}
