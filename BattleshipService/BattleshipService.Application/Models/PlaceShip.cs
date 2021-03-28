using BattleshipService.Application.Enums;

namespace BattleshipService.Application.Models
{
    public class PlaceShip
    {
        public Position Coordinate { get; set; }
        public ShipDirection Direction { get; set; }
        public ShipType ShipType { get; set; }
    }
}
