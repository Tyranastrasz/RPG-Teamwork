namespace RpgGame.Enemies.RangeType
{
    public class Drake : Range
    {
        public Drake(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture)
        {
        }

        //public override int HitPoints { get; set; }
        //public override int DefensePoints { get; set; }
        //public override int AttackPoints { get; set; }
    }
}
