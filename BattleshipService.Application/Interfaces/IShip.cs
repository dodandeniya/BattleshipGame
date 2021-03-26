using BattleshipService.Application.Enums;
using BattleshipService.Application.Models;
using System.Collections.Generic;

namespace BattleshipService.Application.Interfaces
{
    public interface IShip
    {
        int ShipId { get; set; }
        ICollection<Position> BoardPositions { get; set; }
        bool IsSunk { get { return LifeRemaining == 0; } }
        string ShipName { get; }
        ShipType ShipType { get; set; }
        int LifeRemaining { get; }
        int Size { get; }
        FireStatus FireAtShip(Position position);
    }
}
