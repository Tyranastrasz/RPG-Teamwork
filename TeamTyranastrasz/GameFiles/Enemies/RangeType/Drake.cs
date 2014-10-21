namespace RpgGame.Enemies.RangeType
{
    public class Drake : Range
    {
        public const int experience = 50;

        public Drake(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture, experience)
        {
        }

        //public override int HitPoints { get; set; }
        //public override int DefensePoints { get; set; }
        //public override int AttackPoints { get; set; }
    }
}
