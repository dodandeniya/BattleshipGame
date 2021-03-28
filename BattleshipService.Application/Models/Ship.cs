using BattleshipService.Application.Enums;
using BattleshipService.Application.Interfaces;
using System.Collections.Generic;

namespace BattleshipService.Application.Models
{
    public abstract class Ship : IShip
    {
        public int ShipId { get; set; }
        public string ShipName { get { return ShipType.ToString(); } }
        public ShipType ShipType { get; set; }
        public int LifeRemaining { get; set; }
        public int Size { get; set; }
        public bool IsSunk { get { return LifeRemaining == 0; } }

        public virtual ICollection<Position> BoardPositions { get; set; } = new List<Position>();

        public virtual FireStatus FireAtShip(Position position)
        {
            if (BoardPositions.Contains(position))
            {
                LifeRemaining--;

                if (LifeRemaining == 0)
                    return FireStatus.BurnedAndSunk;

                return FireStatus.HasFire;
            }

            return FireStatus.Normal;
        }
    }
}
