using BattleshipService.Application.Player.Commands.CreatePlayer;
using BattleshipService.Application.Player.Queries.GetPlayers;
using BattleshipService.Application.Player.Queries.GetShipList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BattleshipService.Player
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IMediator bus;

        public PlayerController(IMediator bus)
        {
            this.bus = bus;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreatePlayerCommand command)
        {
            return Ok(await bus.Send(command));
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await bus.Send(new GetPlayersQuery()));
        }

        [HttpGet]
        [Route("ShipList")]
        public async Task<IActionResult> GetShipList()
        {
            return Ok(await bus.Send(new GetShipListQuery()));
        }
    }
}
