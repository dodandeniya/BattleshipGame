using BattleshipService.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipService.Application.Player.Commands.CreatePlayer
{
    public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, int>
    {
        private readonly IGameSetup gameSetup;

        public CreatePlayerCommandHandler(IGameSetup gs)
        {
            gameSetup = gs;
        }

        public async Task<int> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            await gameSetup.SetBoard(request.Name);
            return 1;
        }
    }
}
