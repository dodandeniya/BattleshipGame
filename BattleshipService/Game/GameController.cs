using BattleshipService.Application.Game.Queries.GetScores;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BattleshipService.Game
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IMediator bus;

        public GameController(IMediator bus)
        {
            this.bus = bus;
        }

        [HttpGet]
        [Route("Score")]
        public async Task<IActionResult> GetScore()
        {
            return Ok(await bus.Send(new GetScoresQuery()));
        }
    }
}
