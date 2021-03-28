using MediatR;

namespace BattleshipService.Application.Player.Commands.CreatePlayer
{
    public class CreatePlayerCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
