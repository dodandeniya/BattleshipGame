namespace BattleshipService.Domain.Entities
{
    public class Coordinate
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public virtual int ShipId { get; set; }
    }
}
