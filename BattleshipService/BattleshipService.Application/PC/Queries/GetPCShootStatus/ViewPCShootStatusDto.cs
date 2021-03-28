using BattleshipService.Application.Enums;
using BattleshipService.Application.Models;

namespace BattleshipService.Application.PC.Queries.GetPCShootStatus
{
    public class ViewPCShootStatusDto
    {
        public ShootStatus ShootStatus { get; set; }
        public Position Position { get; set; }
    }
}