using BattleshipService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipService.Application.Models
{
    class BoardDimension : IBoardDimension
    {
        public int Width => 10;
        public int Height => 10;
    }
}
