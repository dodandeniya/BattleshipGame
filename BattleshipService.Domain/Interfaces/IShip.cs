using BattleshipService.Domain.Entities;
using BattleshipService.Domain.Enums;
using System.Collections.Generic;

namespace BattleshipService.Domain.Interfaces
{
    public interface IShip
    {
        int ShipId { get; set; }
        ICollection<Coordinate> BoardPositions { get; set; }
        bool IsSunk { get { return LifeRemaining == 0; } }
        string ShipName { get; }
        ShipType ShipType { get; }
        int LifeRemaining { get; }
        int Size { get; }
    }
}