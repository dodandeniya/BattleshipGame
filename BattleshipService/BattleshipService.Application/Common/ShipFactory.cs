using BattleshipService.Application.Enums;
using BattleshipService.Application.Interfaces;
using BattleshipService.Application.Models;

namespace BattleshipService.Application.Common
{
    public class ShipFactory
    {
        public static IShip CreateShip(ShipType shipType)
        {
            IShip ship = null;

            switch (shipType)
            {
                case ShipType.Battleship:
                    ship = new BattleShip();
                    break;

                case ShipType.Destroyer:
                    ship = new Destroyer();
                    break;
            }

            return ship;
        }
    }
}
