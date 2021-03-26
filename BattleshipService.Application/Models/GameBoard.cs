using BattleshipService.Application.Interfaces;
using System.Collections.Generic;

namespace BattleshipService.Application.Models
{
    public class GameBoard
    {
        private readonly int width = 0;
        private readonly int height = 0;

        public ICollection<IShip> ShipList { get; set; }

        public GameBoard(IBoardDimension boardDimension)
        {
            width = boardDimension.Width;
            height = boardDimension.Height;
            ShipList = new List<IShip>();
        }

        private bool IsPositionWithingBoard(Position position)
        {
            return position.XPosition >= 1 && position.XPosition <= width &&
           position.YPosition >= 1 && position.YPosition <= height;
        }
    }
}
