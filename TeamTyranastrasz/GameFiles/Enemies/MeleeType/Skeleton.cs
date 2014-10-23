namespace RpgGame.Enemies.MeleeType
{
    public class Skeleton : Melee
    {
        public const int SkeletonExperience = 50;

        public Skeleton(string name, int hitPoints, int attackPoints, int defensePoints, Pictures picture)
            : base(name, hitPoints, defensePoints, attackPoints, picture, SkeletonExperience)
        {
        }
    }
}
