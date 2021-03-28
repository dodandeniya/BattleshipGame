using BattleshipService.Application.Models;
using MediatR;

namespace BattleshipService.Application.Player.Queries.GetShootStatus
{
    public class GetShootStatusQuery : IRequest<ViewShootStatusDto>
    {
        public Position Position { get; set; }
    }
}
