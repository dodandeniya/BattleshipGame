namespace BattleshipService.Application.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsHuman { get; set; }
        public GameBoard Board { get; set; }
    }
}
