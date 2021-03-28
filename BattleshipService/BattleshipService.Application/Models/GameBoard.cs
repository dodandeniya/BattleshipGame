using BattleshipService.Application.Common;
using BattleshipService.Application.Enums;
using BattleshipService.Application.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BattleshipService.Application.Models
{
    public class GameBoard
    {
        private readonly int width = 10;
        private readonly int height = 10;

        public ICollection<IShip> ShipList { get; set; }

        public GameBoard()
        {
            ShipList = new List<IShip>();
        }

        public ShipPlacement PlaceShip(PlaceShip shipLocation)
        {
            if (!IsPositionWithingBoard(shipLocation.Coordinate))
                return ShipPlacement.OutOfBoundary;

            IShip newShip = ShipFactory.CreateShip(shipLocation.ShipType);

            return shipLocation.Direction switch
            {
                ShipDirection.Down => PlaceShipWhenRightOrDown(shipLocation, newShip),
                ShipDirection.Up => PlaceShipWhenLeftOrUp(shipLocation, newShip),
                ShipDirection.Left => PlaceShipWhenLeftOrUp(shipLocation, newShip),
                _ => PlaceShipWhenRightOrDown(shipLocation, newShip),
            };
        }

        public ShootStatus FireShot(Position position)
        {
            if (!IsPositionWithingBoard(position))
            {
                return ShootStatus.Invalid;
            }

            return CheckShipsForHit(position);
        }

        private ShootStatus CheckShipsForHit(Position position)
        {
            ShootStatus shootStatus = ShootStatus.Miss;

            foreach (var ship in ShipList.Where(s => !s.IsSunk))
            {
                var status = ship.FireAtShip(position);

                shootStatus = status switch
                {
                    FireStatus.BurnedAndSunk => ShootStatus.HitAndSunk,
                    FireStatus.HasFire => ShootStatus.HitAShip,
                    _ => ShootStatus.Miss,
                };

                if (shootStatus != ShootStatus.Miss)
                    break;
            }

            return shootStatus;
        }

        private bool IsPositionWithingBoard(Position position)
        {
            return position.XPosition >= 1 && position.XPosition <= width &&
           position.YPosition >= 1 && position.YPosition <= height;
        }

        private ShipPlacement PlaceShipWhenRightOrDown(PlaceShip shipLocation, IShip newShip)
        {
            int max = 0;
            int min = 0;

            if (shipLocation.Direction == ShipDirection.Down)
            {
                max = shipLocation.Coordinate.YPosition + newShip.Size;
                min = shipLocation.Coordinate.YPosition;
            }
            else if (shipLocation.Direction == ShipDirection.Right)
            {
                max = shipLocation.Coordinate.XPosition + newShip.Size;
                min = shipLocation.Coordinate.XPosition;
            }


            for (int i = min; i < max; i++)
            {
                var currentPosition = (shipLocation.Direction == ShipDirection.Down) ?
                    new Position { XPosition = shipLocation.Coordinate.XPosition, YPosition = i }
                    : new Position { XPosition = i, YPosition = shipLocation.Coordinate.YPosition };

                if (!IsPositionWithingBoard(currentPosition))
                    return ShipPlacement.OutOfBoundary;

                if (OverlapsWithAnotherShip(currentPosition))
                    return ShipPlacement.Overlap;

                newShip.BoardPositions.Add(currentPosition);
            }

            AddShipToBoard(newShip);
            return ShipPlacement.Ok;
        }

        private ShipPlacement PlaceShipWhenLeftOrUp(PlaceShip shipLocation, IShip newShip)
        {
            int max = 0;
            int min = 0;

            if (shipLocation.Direction == ShipDirection.Up)
            {
                max = shipLocation.Coordinate.YPosition;
                min = shipLocation.Coordinate.YPosition - newShip.Size;
            }
            else if (shipLocation.Direction == ShipDirection.Left)
            {
                max = shipLocation.Coordinate.XPosition;
                min = shipLocation.Coordinate.XPosition - newShip.Size;
            }


            for (int i = max; i > min; i--)
            {
                var currentPosition = (shipLocation.Direction == ShipDirection.Up) ?
                    new Position { XPosition = shipLocation.Coordinate.XPosition, YPosition = i }
                    : new Position { XPosition = i, YPosition = shipLocation.Coordinate.YPosition };

                if (!IsPositionWithingBoard(currentPosition))
                    return ShipPlacement.OutOfBoundary;

                if (OverlapsWithAnotherShip(currentPosition))
                    return ShipPlacement.Overlap;

                newShip.BoardPositions.Add(currentPosition);
            }

            AddShipToBoard(newShip);
            return ShipPlacement.Ok;
        }

        private bool OverlapsWithAnotherShip(Position position)
        {
            foreach (var ship in ShipList)
            {
                if (ship.BoardPositions.Contains(position))
                    return true;
            }

            return false;
        }

        private void AddShipToBoard(IShip newShip)
        {
            ShipList.Add(newShip);

        }
    }
}
