using BattleshipService.Application.Enums;
using BattleshipService.Application.Interfaces;
using BattleshipService.Application.utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BattleshipService.Application.Models
{
    public class GameSetup : IGameSetup
    {
        public GameState State { get; set; } = new GameState();

        public async Task SetBoard(string name)
        {
            //Create user
            State.Player1.Name = name;
            State.Player1.Board = new GameBoard();
            State.Player1.IsHuman = true;
            await AddShips(State.Player1);

            //Create pc
            State.Player2.Name = "PC";
            State.Player2.Board = new GameBoard();
            await AddShips(State.Player2);
        }

        private async Task AddShips(Player player)
        {
            List<ShipType> ships = new List<ShipType>() { ShipType.Battleship, ShipType.Destroyer, ShipType.Destroyer };

            foreach (var i in ships)
            {
                ShipPlacement result;

                do
                {
                    var shipLocation = RandomGenerator.RandomLocation();
                    shipLocation.ShipType = i;
                    result = player.Board.PlaceShip(shipLocation);

                } while (result != ShipPlacement.Ok);
            }
        }
    }
}
