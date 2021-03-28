using MediatR;

namespace BattleshipService.Application.Game.Queries.GetWinner
{
    public class GetWinnerQuery : IRequest<ViewWinnerDto>
    {
    }
}
