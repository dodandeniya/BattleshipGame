using MediatR;
using System.Collections.Generic;

namespace BattleshipService.Application.Game.Queries.GetScores
{
    public class GetScoresQuery : IRequest<List<ViewGetScoreQueryDto>>
    {
    }
}
