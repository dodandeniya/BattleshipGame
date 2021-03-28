using System.Collections.Generic;

namespace BattleshipService.Application.Models
{
    public class Destroyer : Ship
    {
        private readonly int size = 4;

        public Destroyer()
        {
            BoardPositions = new List<Position>();
            Size = size;
            LifeRemaining = Size;
            ShipType = Enums.ShipType.Destroyer;
        }
    }
}
