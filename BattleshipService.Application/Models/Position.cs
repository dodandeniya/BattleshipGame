namespace BattleshipService.Application.Models
{
    public class Position
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public Position(int x, int y)
        {
            XPosition = x;
            YPosition = y;
        }
    }
}
