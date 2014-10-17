namespace RpgGame.Enemies.MeleeType
{
    public class Ork : Melee
    {
        public Ork(string name): base(name)
        {
        }

        public override int HitPoints { get; set; }
        public override int DefensePoints { get; set; }
        public override int AttackPoints { get; set; }
    }
}
