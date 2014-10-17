namespace RpgGame.Enemies.MeleeType
{
    public class Golem : Melee
    {
        public Golem(string name) : base(name)
        {
        }

        public override int HitPoints { get; set; }
        public override int DefensePoints { get; set; }
        public override int AttackPoints { get; set; }
    }
}
