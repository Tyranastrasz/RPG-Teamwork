namespace RpgGame.Enemies.MeleeType
{
    public class Ork : Melee
    {
        public const int experience = 50;

        public Ork(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture, experience)
        {
        }

        //public override int HitPoints { get; set; }
        //public override int DefensePoints { get; set; }
        //public override int AttackPoints { get; set; }
    }
}
