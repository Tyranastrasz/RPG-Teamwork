namespace RpgGame.Enemies.MeleeType
{
    public class Skeleton : Melee
    {
        public const int experience = 500;

        public Skeleton(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture, experience)
        {
        }

        //public override int HitPoints { get; set; }
        //public override int DefensePoints { get; set; }
        //public override int AttackPoints { get; set; }
    }
}
