using MediatR;
using System.Collections.Generic;

namespace BattleshipService.Application.Player.Queries.GetPlayers
{
    public class GetPlayersQuery : IRequest<List<ViewPlayerDto>>
    {

    }
}
