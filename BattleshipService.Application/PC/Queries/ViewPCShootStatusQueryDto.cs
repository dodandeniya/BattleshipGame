using BattleshipService.Application.Enums;
using BattleshipService.Application.Models;

namespace BattleshipService.Application.PC.Queries
{
    public class ViewPCShootStatusQueryDto
    {
        public ShootStatus ShootStatus { get; set; }
        public Position Position { get; set; }
    }
}