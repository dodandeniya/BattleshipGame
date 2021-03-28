using System.Collections.Generic;

namespace BattleshipService.Application.Models
{
    public class BattleShip : Ship
    {
        private readonly int size = 5;

        public BattleShip()
        {
            BoardPositions = new List<Position>();
            Size = size;
            LifeRemaining = Size;
            ShipType = Enums.ShipType.Battleship;
        }
    }
}
