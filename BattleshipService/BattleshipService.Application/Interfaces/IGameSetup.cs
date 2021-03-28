using BattleshipService.Application.Models;
using System.Threading.Tasks;

namespace BattleshipService.Application.Interfaces
{
    public interface IGameSetup
    {
        GameState State { get; set; }
        Task SetBoard(string name);
    }
}