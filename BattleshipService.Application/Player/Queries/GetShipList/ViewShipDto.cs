using BattleshipService.Application.Enums;
using BattleshipService.Application.Models;
using System.Collections.Generic;

namespace BattleshipService.Application.Player.Queries.GetShipList
{
    public class ViewShipDto
    {
        public ICollection<Position> BoardPositions { get; set; }
        public bool IsSunk { get { return LifeRemaining == 0; } }
        public string ShipName { get; set; }
        public ShipType ShipType { get; set; }
        public int LifeRemaining { get; set; }
        public int Size { get; set; }
    }
}