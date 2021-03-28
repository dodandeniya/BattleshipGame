using MediatR;
using System.Collections.Generic;

namespace BattleshipService.Application.Player.Queries.GetShipList
{
    public class GetShipListQuery : IRequest<List<ViewShipDto>>
    {
    }
}
