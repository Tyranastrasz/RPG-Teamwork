namespace RpgGame.Enemies.RangeType
{
    public class Shade : Range
    {
        public Shade(string name) : base(name)
        {
        }

        public override int HitPoints { get; set; }
        public override int DefensePoints { get; set; }
        public override int AttackPoints { get; set; }
    }
}
