using BattleshipService.Application.PC.Queries.GetPCShootStatus;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BattleshipService.PC
{
    [Route("api/[controller]")]
    [ApiController]
    public class PCController : ControllerBase
    {
        private readonly IMediator bus;

        public PCController(IMediator bus)
        {
            this.bus = bus;
        }

        [HttpGet]
        [Route("ShootStatus")]
        public async Task<IActionResult> GetShootStatus()
        {
            return Ok(await bus.Send(new GetPCShootStatusQuery()));
        }
    }
}
