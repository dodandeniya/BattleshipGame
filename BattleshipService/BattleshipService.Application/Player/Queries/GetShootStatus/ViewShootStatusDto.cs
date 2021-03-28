using BattleshipService.Application.Enums;
using BattleshipService.Application.Models;

namespace BattleshipService.Application.Player.Queries.GetShootStatus
{
    public class ViewShootStatusDto
    {
        public ShootStatus ShootStatus { get; set; }
        public Position Position { get; set; }
    }
}
