namespace RpgGame.Enemies.MeleeType
{
    public class Skeleton : Melee
    {
        public Skeleton(string name): base(name)
        {
        }

        public override int HitPoints { get; set; }
        public override int DefensePoints { get; set; }
        public override int AttackPoints { get; set; }
    }
}
