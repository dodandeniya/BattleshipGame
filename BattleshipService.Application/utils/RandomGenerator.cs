using BattleshipService.Application.Enums;
using BattleshipService.Application.Models;
using System;

namespace BattleshipService.Application.utils
{
    public static class RandomGenerator
    {
        public static Random random = new Random();

        public static PlaceShip RandomLocation()
        {
            return new PlaceShip()
            {
                Direction = GetRandomDirection(),
                Coordinate = GetRandomCoordinate()
            };
        }

        public static ShipDirection GetRandomDirection()
        {
            return (random.Next(1, 4)) switch
            {
                1 => ShipDirection.Left,
                2 => ShipDirection.Right,
                3 => ShipDirection.Up,
                4 => ShipDirection.Down,
                _ => ShipDirection.Left,
            };
        }

        public static Position GetRandomCoordinate()
        {
            return new Position(random.Next(1, 10), random.Next(1, 10));
        }
    }
}
