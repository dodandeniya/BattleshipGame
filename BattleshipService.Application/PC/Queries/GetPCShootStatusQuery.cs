using MediatR;

namespace BattleshipService.Application.PC.Queries
{
    public class GetPCShootStatusQuery : IRequest<ViewPCShootStatusQueryDto>
    {
    }
}
