namespace BattleshipService.Application.Models
{
    public class GameState
    {
        public bool IsPlayer1 { get; set; }
        public Player Player1 { get; set; } = new Player();
        public Player Player2 { get; set; } = new Player();
    }
}
