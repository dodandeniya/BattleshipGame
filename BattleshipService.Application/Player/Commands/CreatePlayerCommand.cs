using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipService.Application.Player.Commands
{
    public class CreatePlayerCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
