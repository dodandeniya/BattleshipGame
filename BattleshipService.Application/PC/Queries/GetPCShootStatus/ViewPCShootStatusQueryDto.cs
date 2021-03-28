using BattleshipService.Application.Enums;
using BattleshipService.Application.Models;

namespace BattleshipService.Application.PC.Queries.GetPCShootStatus
{
    public class ViewPCShootStatusQueryDto
    {
        public ShootStatus ShootStatus { get; set; }
        public Position Position { get; set; }
    }
}