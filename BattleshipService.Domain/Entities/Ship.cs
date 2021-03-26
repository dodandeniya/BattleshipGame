using BattleshipService.Domain.Enums;
using BattleshipService.Domain.Interfaces;
using System.Collections.Generic;

namespace BattleshipService.Domain.Entities
{
    public class Ship : IShip
    {
        public int ShipId { get; set; }
        public string ShipName { get { return ShipType.ToString(); } }
        public ShipType ShipType { get; private set; }
        public int LifeRemaining { get; private set; }
        public int Size { get; private set; }

        public virtual ICollection<Coordinate> BoardPositions { get; set; }
    }
}
